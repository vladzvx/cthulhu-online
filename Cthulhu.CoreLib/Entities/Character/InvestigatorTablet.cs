using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;
using Cthulhu.CoreLib.Entities.Possessions;
using Cthulhu.CoreLib.Entities.Character.Common;
using Cthulhu.CoreLib.Entities.Character.Stats;
using System.Collections.Concurrent;
using MongoDB.Driver.Linq;
using System.Linq;

namespace Cthulhu.CoreLib.Entities.Character
{
    public class InvestigatorTablet
    {
        #region view

        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public DateTime BirthDate { get; private set; }

        public double Sanity => Ranks[Stat.Common.Sanity.StatId];
        public double HealthValue => Values[Stat.Common.Health.StatId];
        public double HealthRank=> Ranks[Stat.Common.Health.StatId];
        public double ComposureValue => Values[Stat.Common.Composure.StatId];
        public double ComposureRank => Ranks[Stat.Common.Composure.StatId];

        public double Defence { get; set; } = 4;
        public double Armor { get; set; } = 0;
        #endregion
        #region Общая информация 





        private readonly object _lock = new object();
        private TabletStatus _status;
        public TabletStatus Status
        {
            get
            {
                lock (_lock)
                {
                    return _status;
                }
            }
            private set
            {
                lock (_lock)
                {
                    _status = value;
                }
            }
        }
        public double CommonStatsTotal { get; set; } = 65;
        public double InvestigationStatsTotal { get; set; } = 18;
        public double CommonStatsUsed { get; set; }
        public double InvestigationStatsUsed { get; set; }


        /// <summary>
        /// Архетип (хобо, дилетант и т.д.)
        /// </summary>
        public Archetype Archetype { get; private set; } = Archetype.Instances.Vagabond;
        public ConcurrentDictionary<long, double> Ranks { get; private set; } = new ConcurrentDictionary<long, double>();
        public ConcurrentDictionary<long, double> Values { get; private set; } = new ConcurrentDictionary<long, double>();
        public ConcurrentDictionary<long, double?> Professionals { get; private set; } = new ConcurrentDictionary<long, double?>();

        private ConcurrentBag<Stat> UnselectedProfessionals = new ConcurrentBag<Stat>();

        public InvestigatorTablet(Archetype archetype, string name)
        {
            Name = name;
            Status = TabletStatus.Created;
            foreach (var kvp in archetype.ProfessionalStats)
            {
                if (kvp.Value.StatId > 0)
                {
                    Professionals.TryAdd(kvp.Key, null);
                }
                else
                {
                    UnselectedProfessionals.Add(kvp.Value);
                }
            }
            foreach (var st in Stat.CommonStats)
            {
                Ranks[st.Key] = 0;
                Values[st.Key] = 0;
            }
            foreach (var st in Stat.InvestigateStats)
            {
                Ranks[st.Key] = 0;
                Values[st.Key] = 0;
            }

            Ranks[Stat.Common.Sanity.StatId] = 10;
            CommonStatsUsed += 10;
            Ranks[Stat.Common.Health.StatId] = 12;
            CommonStatsUsed += 12;
            Ranks[Stat.Common.Composure.StatId] = 12;
            CommonStatsUsed += 12;
        }

        public bool TryGetProfessionalsForSelection(out Stat[] result)
        {
            result = Array.Empty<Stat>();
            if (UnselectedProfessionals.TryTake(out var st))
            {
                var res = new List<Stat>();
                UnwrapStatsForSelection(st, res);
                return res.Count > 0;
            }
            return false;
        }

        public void SetProfessional(long statId)
        {
            if (!Professionals.ContainsKey(statId))
            {
                Professionals[statId] = 0;
                Ranks[statId] = Ranks[statId] * 2;
            }
        }

        public void RemoveProfessional(long statId)
        {
            if (Professionals.ContainsKey(statId))
            {
                Professionals.TryRemove(statId, out _);
                Ranks[statId] = Ranks[statId] / 2;
            }
        }

        public void DistributeValue(long statId, double value =1)
        {
            var mult = Professionals.ContainsKey(statId) ? 2 : 1;
            if (Stat.CommonStats.ContainsKey(statId) && CommonStatsTotal- CommonStatsUsed>=value)
            {
                Ranks[statId] = Ranks[statId] + mult * value;
                CommonStatsUsed += value;
            }
            else if (Stat.InvestigateStats.ContainsKey(statId) && InvestigationStatsTotal-InvestigationStatsUsed>=value)
            {
                Ranks[statId] = Ranks[statId] + mult * value;
                InvestigationStatsUsed += value;
            }
        }

        public void UndistributeValue(long statId, double value = 1)
        {
            if (Ranks[statId]<value) value = Ranks[statId];
            var mult = Professionals.ContainsKey(statId) ? 2 : 1;
            if (Stat.CommonStats.ContainsKey(statId) && CommonStatsUsed > 0)
            {
                Ranks[statId] = Ranks[statId] - value;
                CommonStatsUsed -= value / mult;
            }
            else if (Stat.InvestigateStats.ContainsKey(statId) && InvestigationStatsUsed > 0)
            {
                Ranks[statId] = Ranks[statId] - value;
                InvestigationStatsUsed -= value / mult;
            }
        }

        public static void UnwrapStatsForSelection(Stat stat, List<Stat> forResult)
        {
            if (stat.StatId<=0 && stat.OneOf!=null && stat.OneOf.Count>0)
            {
                var forContinue = stat.OneOf.Where(o => o.StatId <= 0);
                forResult.AddRange(stat.OneOf.Where(o => o.StatId > 0));
                foreach (var fc in forContinue)
                {
                    UnwrapStatsForSelection(fc, forResult);
                }
            }
            return;
        }

        public PersonRole PersonRole { get; set; }
        public PersonSpices PersonSpices { get; set; }



        /// <summary>
        /// Мотив (любоптство и т.д.)
        /// </summary>
        public Motive Motive { get; set; } = new Motive();

        /// <summary>
        /// Душевные опоры
        /// </summary>
        public List<SoulSupport> SoulSupports { get; set; } = new List<SoulSupport>();

        /// <summary>
        /// Факторы самообладания
        /// </summary>
        public List<ComposureFactor> ComposureFactors { get; set; } = new List<ComposureFactor>();

        #endregion

        #region Характеристики сыщика
        #endregion

        #region Имущество сыщика
        public List<Possession> Possessions { get; set; } = new List<Possession>();
        #endregion

        #region Действия

        public void AddCommonStatPoints(double value = 1)
        {
            CommonStatsTotal+= value;
        }

        public void AddInvestigateStatPoints(double value = 1)
        {
            InvestigationStatsTotal -= value;
        }

        public void RemoveCommonStatPoints(double value = 1)
        {
            CommonStatsTotal -= value;
        }

        public void RemoveInvestigateStatPoints(double value = 1)
        {
            InvestigationStatsTotal -= value;
        }
        #endregion
    }
}
