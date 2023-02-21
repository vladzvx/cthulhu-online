using Cthulhu.CoreLib.Entities.Character;
using Cthulhu.CoreLib.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cthulhu.Service.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;
        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public async Task<Person> GetPerson(/*[FromQuery] Guid id*/)
        {
            return await _personRepository.GetPerson(Guid.Empty);
        }

        [HttpGet]
        public async Task UpdateSkill(Skill skill, [FromQuery] Guid personId)
        {
            await _personRepository.UpdateSkill(skill, personId);
        }

        [HttpGet]
        public async Task UpsertPerson(Person skill)
        {
            await _personRepository.UpsertPerson(skill);
        }
    }
}
