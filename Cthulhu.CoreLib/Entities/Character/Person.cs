using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character
{
    public class Person
    {
        /// <summary>
        /// Id персонажа
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя персонажа
        /// </summary>
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Краткая биография
        /// </summary>
        public string Bio { get; set; } = string.Empty;
        /// <summary>
        /// Счетчик игр
        /// </summary>
        public int GameCounter { get; set; }
        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get; set; }
        /// <summary>
        /// Максимальный лимит очков общих способностей
        /// </summary>
        public double CommonSkillsLimit { get; set; } = 65;
        /// <summary>
        /// Максимальный лимит очков исследовательских способностей
        /// </summary>
        public double InvestigateSkillsLimit { get; set; } = 20;
        /// <summary>
        /// Остаток очков Общих способностей
        /// </summary>
        public double CommonSkillsBalance { get; set; } = 65;
        /// <summary>
        /// Остаток очков исследовательских способностей
        /// </summary>
        public double InvestigateSkillsBalance { get; set; } = 20;
        /// <summary>
        /// Здоровье
        /// </summary>
        public Skill? Health { get; set; }
        /// <summary>
        /// Рассудок
        /// </summary>
        public Skill? Sanity { get; set; }
        /// <summary>
        /// Самообладание
        /// </summary>
        public Skill? Control { get; set; }
        /// <summary>
        /// Факторы самообладания
        /// </summary>
        public PersonReduced[] ControlFactors { get; set; } = Array.Empty<PersonReduced>();
        /// <summary>
        /// Жизненные опоры (ценности)
        /// </summary>
        public Value[] Values { get; set; } = Array.Empty<Value>();
        /// <summary>
        /// Общие способности
        /// </summary>
        public  Skill[] CommonSkills { get; set; } = Array.Empty<Skill>();
        /// <summary>
        /// Исследовательские способности
        /// </summary>
        public Skill[] InvestigateSkills { get; set; } = Array.Empty<Skill>();
    }
}
