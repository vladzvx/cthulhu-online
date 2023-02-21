using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character
{
    public class PersonReduced
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public int GameCounter { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
