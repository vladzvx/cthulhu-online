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
        public readonly static ImmutableList<Stat> Stats = CreateStatsArray();
        public readonly static ImmutableDictionary<long,Stat> EmptyDict = new Dictionary<long,Stat>().ToImmutableDictionary();
        public static Stat GetOneOf(params Stat[] stats)
        {
            return new Stat()
            {
                Name = "Одна из",
                OneOf = new HashSet<Stat>(stats),
                RestoringSpec = StatRestoringSpec.Unspec,
                StatId = 0,
                Type = StatType.OneOf
            };
        }
        private static ImmutableList<Stat> CreateStatsArray()
        {
            var result = new List<Stat>();
            ReadStats(typeof(Stat), result);
            ReadStats(typeof(Stat.Common), result);
            ReadStats(typeof(Stat.Scientific), result);
            ReadStats(typeof(Stat.Social), result);
            ReadStats(typeof(Stat.Applied), result);
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
