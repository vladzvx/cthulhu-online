using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Cthulhu.CoreLib.Entities.Character.Stats
{
    public partial class Stat
    {
        public long StatId { get; private set; }
        public StatType Type { get; private set; }
        public StatRestoringSpec RestoringSpec { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public HashSet<Stat>? OneOf { get; private set; }

        #region Static
        public readonly static ImmutableList<Stat> Stats = CreateStatsArray(true,true, true, true, true, true);
        public readonly static ImmutableDictionary<long, Stat> CommonStats = CreateStatsArray(false, false, true, false, false, false).ToImmutableDictionary(cs => cs.StatId);
        public readonly static ImmutableDictionary<long, Stat> InvestigateStats = CreateStatsArray(false,false, false, true, true, true).ToImmutableDictionary(cs => cs.StatId);
        public readonly static ImmutableList<Stat> ScientificStats = CreateStatsArray(false,false, false, true, false, false);
        public readonly static ImmutableList<Stat> SocialStats = CreateStatsArray(false,false, false, false, true, false);
        public readonly static ImmutableList<Stat> AppliedStats = CreateStatsArray(false,false, false, false, false, true);


        public readonly static ImmutableDictionary<long, Stat> EmptyDict = new Dictionary<long, Stat>().ToImmutableDictionary();
        public static Stat GetOneOf(params Stat[] stats)
        {
            return new Stat()
            {
                Name = "Одна из",
                OneOf = new HashSet<Stat>(stats),
                RestoringSpec = StatRestoringSpec.Unspec,
                StatId = -10,
                Type = StatType.OneOf
            };
        }
        private static ImmutableList<Stat> CreateStatsArray(bool any,bool anyInvestigate, bool common,bool scientific, bool social, bool applied)
        {
            var result = new List<Stat>();
            if (any) result.Add(Stat.Any);
            if (anyInvestigate) result.Add(Stat.AnyInvestigate);
            if (common) ReadStats(typeof(Stat.Common), result);
            if (scientific) ReadStats(typeof(Stat.Scientific), result);
            if (social) ReadStats(typeof(Stat.Social), result);
            if (applied) ReadStats(typeof(Stat.Applied), result);
            //result.RemoveAll(s => s.StatId <= 0);
            return result.ToImmutableList();
        }

        private static void ReadStats(Type type, List<Stat> forResult)
        {
            if (type==null) return;
            var props = type.GetProperties();
            foreach (var prop in props)
            {
                if (prop.CanRead && prop.PropertyType.IsPublic)
                {
                    var fieldValue = prop.GetValue(null);
                    if (fieldValue != null && fieldValue is Stat st)
                    {
                        forResult.Add(st);
                    }
                }
            }
        }
        #endregion
    }
}
