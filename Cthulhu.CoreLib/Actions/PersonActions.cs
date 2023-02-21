using Cthulhu.CoreLib.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cthulhu.CoreLib.Actions
{
    public static class PersonActions
    {
        public static Person RestoreHalf(this Person person)
        {
            foreach (var skill in person.CommonSkills)
            {
                if (skill.Type == Entities.Enums.SkillType.Common)
                {
                    var diff = skill.MaxValue - skill.Value;
                    skill.Value += Math.Ceiling(diff / 2);
                }
            }
            return person;
        }

        public static Person RestoreThird(this Person person)
        {
            foreach (var skill in person.CommonSkills)
            {
                if (skill.Type == Entities.Enums.SkillType.Common)
                {
                    var diff = skill.MaxValue - skill.Value;
                    skill.Value += Math.Ceiling(diff / 3);
                }
            }
            return person;
        }

        public static Person RestoreFull(this Person person)
        {
            foreach (var skill in person.CommonSkills)
            {
                if (skill.Type == Entities.Enums.SkillType.Common)
                {
                    skill.Value = skill.MaxValue;
                }
            }
            return person;
        }

        public static bool Checkup(this Person person, Guid skillId,double pointsAdded, double treshold)
        {
            var skill = person.CommonSkills.FirstOrDefault(s=>s.Id == skillId);
            if (skill!=null)
            {
                var checkup = skill.Test(treshold, pointsAdded);
                return checkup.Status == Entities.Enums.CheckupStatus.Success;
            }
            return false;
        }
    }
}
