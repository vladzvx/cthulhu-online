using Cthulhu.CoreLib.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character
{
    public class Skill
    {
        public Guid Id { get; set; }
        public SkillType Type { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Value { get; set; }
        public double MaxValue { get; set; }
        public bool IsProffessional { get; set; }
    }
}
