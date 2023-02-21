using Cthulhu.CoreLib.Entities.Character;
using Cthulhu.CoreLib.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Cthulhu.CoreLib.Actions
{
    public static class SkillActions
    {
        public static Checkup Test(this Skill skill, double threshold, double added)
        {
            if (skill.Value < added) throw new ArgumentException($"Value in skill must be >= added. Value:{skill.Value}; Added:{added}");

            var result = new Checkup(threshold, added);
            result.Execute();
            return result;
        }
    }
}
