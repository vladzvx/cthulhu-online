using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character.Stats
{
    public partial class Stat
    {
        public long StatId { get; set; }
        public StatType Type { get; set; }
        public StatRestoringSpec RestoringSpec { get; set; }
        public string Name { get; set; } = string.Empty;

        #region Static
        public readonly static ImmutableList<Stat> Stats = CreateStatsArray();
        public readonly static ImmutableDictionary<long,Stat> EmptyDict = new Dictionary<long,Stat>().ToImmutableDictionary();

        private static ImmutableList<Stat> CreateStatsArray()
        {
            var result = new List<Stat>();
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
