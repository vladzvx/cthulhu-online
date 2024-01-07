using System;
using System.Collections.Generic;

namespace Cthulhu.CoreLib.Entities.Character.Common
{
    /// <summary>
    /// Конкретный персонаж
    /// </summary>
    public class Person
    {
        public long PersonId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public PersonRole PersonRole { get; set; }
        public PersonSpices PersonSpices { get; set; }
    }
}
