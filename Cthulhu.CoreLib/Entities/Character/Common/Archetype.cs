using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character.Common
{
    /// <summary>
    /// Тип персонажа
    /// </summary>
    public class Archetype
    {
        public long ArchetypeId { get; set; }
        public string Name { get; set; } = string.Empty;

        public static Archetype Default = new Archetype()
        {
            ArchetypeId = 0,
            Name = "Хобо"
        };
    }
}
