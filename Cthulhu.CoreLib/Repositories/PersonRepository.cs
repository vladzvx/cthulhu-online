using Cthulhu.CoreLib.Entities.Character;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cthulhu.CoreLib.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        public async Task<Person> GetPerson(Guid id)
        {
            await Task.Delay(0);
            return await GetPerson();
        }

        public async Task<Person> GetPerson()
        {
            await Task.Delay(0);
            return new Person()
            {
                Id = Guid.Empty,
                Bio = "родился, вырос, умер",
                Name = "Иванов Иванг Иванович",
                BirthDate = DateTime.UtcNow.AddYears(-30),
                CommonSkills = new Skill[] {
                new Skill()
                {
                    Id = Guid.NewGuid(),
                    Type = Entities.Enums.SkillType.Common,
                    Description = "атлетика описание",
                    Name = "атлетика",
                    Value = 12,
                    MaxValue = 16
                },
                new Skill()
                {
                    Id = Guid.NewGuid(),
                    Type = Entities.Enums.SkillType.Common,
                    Description = "бдительность описание",
                    Name = "бдительность",
                    Value = 12,
                    IsProffessional = true,
                    MaxValue = 14
                }
                },
                InvestigateSkills = new Skill[] {
                new Skill()
                {
                    Id = Guid.NewGuid(),
                    Type = Entities.Enums.SkillType.Investigative,
                    Description = "книжные изыскания описание",
                    Name = "книжные изыскания",
                    Value = 12,
                    MaxValue = 17
                }
                },
                CommonSkillsBalance = 11,
                CommonSkillsLimit = 11,
                Control = new Skill()
                {
                    Id = Guid.NewGuid(),
                    Type = Entities.Enums.SkillType.Main,
                    Name = "Самообладание"
                },
                Health = new Skill()
                {
                    Id = Guid.NewGuid(),
                    Type = Entities.Enums.SkillType.Main,
                    Name = "Здоровье"
                },
                Sanity = new Skill()
                {
                    Id = Guid.NewGuid(),
                    Type = Entities.Enums.SkillType.Main,
                    Name = "Рассудок"
                },
                Values = new Value[]
                {
                    new Value()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Ценность человеческой жизни"
                    }
                },
                GameCounter = 1,
                ControlFactors = new PersonReduced[]
                {
                    new PersonReduced()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Фактор1",
                        Bio = "Био"
                    }
                },
                InvestigateSkillsBalance =11,
                InvestigateSkillsLimit =33
            };
        }

        public async Task UpdateSkill(Skill skill, Guid personId)
        {
            await Task.Delay(0);
        }

        public async Task UpsertPerson(Person skill)
        {
            await Task.Delay(0);
        }
    }
}
