using Cthulhu.CoreLib.Entities.Character.Stats;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character.Common
{
    /// <summary>
    /// Тип персонажа
    /// </summary>
    public partial class Archetype
    {
        public long ArchetypeId { get; private set; }
        public double MinStatusValue { get; private set; }
        public double MaxStatusValue { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public ImmutableDictionary<long, Stat> ProfessionalStats { get; private set; } = Stat.EmptyDict;
    }

}
