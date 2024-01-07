using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character.Common
{
    /// <summary>
    /// Роль персонажа в игре
    /// </summary>
    public enum PersonRole
    {
        /// <summary>
        /// Сыщик
        /// </summary>
        Investigator = 0,
        /// <summary>
        /// Спутник сыщика
        /// </summary>
        InvestigatorServant = 1,
        /// <summary>
        /// Неигровой персонаж
        /// </summary>
        NPC = 2,
        /// <summary>
        /// Шаблон для создания персонажа. Например - вурдалак
        /// </summary>
        Template = 3,
    }
}
