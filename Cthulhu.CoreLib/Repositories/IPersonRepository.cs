using Cthulhu.CoreLib.Entities.Character;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cthulhu.CoreLib.Repositories
{
    public interface IPersonRepository
    {
        public Task<Person> GetPerson(Guid id);
        public Task UpdateSkill(Skill skill, Guid personId);
        public Task UpsertPerson(Person skill);
    }
}
