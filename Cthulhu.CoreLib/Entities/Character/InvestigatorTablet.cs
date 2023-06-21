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
        #region Общая информация 
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public PersonRole PersonRole { get; set; }
        public PersonSpices PersonSpices { get; set; }

        /// <summary>
        /// Архетип (хобо, дилетант и т.д.)
        /// </summary>
        public Archetype Archetype { get; set; } = Archetype.Default;

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
        public double CommonStatsTotal { get; set; }
        public double InvestigationStatsTotal { get; set; }
        public double CommonStatsUsed { get; set; }
        public double InvestigationStatsUsed { get; set; }
        public double Defence { get; set; } = 4;
        public double Armor { get; set; } = 0;

        public StatValue Sanity { get; set; } = new StatValue();
        public StatValue Health { get; set; } = new StatValue();
        public StatValue Composure { get; set; } = new StatValue();
        public ConcurrentDictionary<long, StatValue> CommonStats { get; set; } = new ConcurrentDictionary<long, StatValue>();
        public ConcurrentDictionary<long, StatValue> InvestigationStats { get; set; } = new ConcurrentDictionary<long, StatValue>();
        public ConcurrentDictionary<long, StatValue> AllStats { get; set; } = new ConcurrentDictionary<long, StatValue>();
        #endregion

        #region Имущество сыщика
        public List<Possession> Possessions { get; set; } = new List<Possession>();
        #endregion

        #region Действия
        public void DistributeStatValue(long StatId, double value)
        {
            if (AllStats.TryGetValue(StatId, out StatValue statValue))
            {
                var removingValue = statValue.IsProfessional ? value / 2 : value;
                if (statValue.Type == StatType.Common)
                {
                    if (CommonStatsTotal - CommonStatsUsed >= removingValue)
                    {
                        statValue.MaxValue += value;
                        statValue.CurrentValue += value;
                        CommonStatsUsed += removingValue;
                    }
                }
                else
                {
                    if (InvestigationStatsTotal - InvestigationStatsUsed >= removingValue)
                    {
                        statValue.MaxValue += value;
                        statValue.CurrentValue += value;
                        InvestigationStatsUsed += removingValue;
                    }
                }
            }
        }

        public void AddStatPoints(long StatId, double value)
        {
            if (AllStats.TryGetValue(StatId, out StatValue statValue))
            {
                var addingValue = statValue.IsProfessional ? value * 2 : value;
                statValue.MaxValue += addingValue;
                statValue.CurrentValue += addingValue;
                if (statValue.Type == StatType.Common)
                {
                    CommonStatsTotal += value;
                    CommonStatsUsed += value;
                }
                else
                {
                    InvestigationStatsTotal += value;
                    InvestigationStatsUsed += value;
                }
            }
        }

        public void RemoveStatPoints(long StatId, double value)
        {
            if (AllStats.TryGetValue(StatId, out StatValue statValue))
            {
                var addingValue = statValue.IsProfessional ? value * 2 : value;
                statValue.MaxValue -= addingValue;
                statValue.CurrentValue -= addingValue;
                if (statValue.Type == StatType.Common)
                {
                    CommonStatsTotal -= value;
                    CommonStatsUsed -= value;
                }
                else
                {
                    InvestigationStatsTotal -= value;
                    InvestigationStatsUsed -= value;
                }
            }
        }

        public void FreeValuePoint(long StatId, double value = 1)
        {
            if (AllStats.TryGetValue(StatId, out StatValue statValue))
            {
                var removingValue = statValue.IsProfessional ? value * 2 : value;
                statValue.MaxValue -= removingValue;
                statValue.CurrentValue -= removingValue;
                CommonStatsUsed -= value;
            }
        }

        public void SetSkillProfessional(long StatId)
        {
            if (AllStats.TryGetValue(StatId, out StatValue statValue))
            {
                if (!statValue.IsProfessional)
                {
                    statValue.IsProfessional = true;
                    statValue.MaxValue = statValue.MaxValue * 2;
                    statValue.CurrentValue = statValue.CurrentValue * 2;
                }
            }
        }

        public void CancellSkillProfessional(long StatId)
        {
            if (AllStats.TryGetValue(StatId, out StatValue statValue))
            {
                if (statValue.IsProfessional)
                {
                    statValue.IsProfessional = false;
                    statValue.MaxValue = Math.Round(statValue.MaxValue / 2);
                    statValue.CurrentValue = Math.Round(statValue.CurrentValue / 2);
                }
            }
        }

        public void Restore(RestorationMod restorationMod)
        {
            var stats = AllStats.Values.Where(s => s.RestoringSpec == StatRestoringSpec.Nightly);
            foreach (var stat in stats)
            {
                stat.Restore(restorationMod);
            }
        }

        public double GetStatPoints(long StatId, double value)
        {
            if (AllStats.TryGetValue(StatId, out StatValue statValue))
            {
                if (statValue.CurrentValue >= value)
                {
                    statValue.CurrentValue -= value;
                    return value;
                }
                else
                {
                    value = statValue.CurrentValue;
                    statValue.CurrentValue = 0;
                    return value;
                }
            }
            else return 0;
        }

        private void NormalizeValues()
        {
            foreach (var kvp  in AllStats)
            {
                kvp.Value.NormalizeValues();
            }
        }
        #endregion
    }
}
