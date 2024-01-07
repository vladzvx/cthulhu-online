using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character.Stats
{
    /// <summary>
    /// Тип параметра
    /// </summary>
    public enum StatType : byte
    {
        /// <summary>
        /// Неопределенный
        /// </summary>
        Unspec = 0,
        /// <summary>
        /// Общие - здоровье, атлетика и т.д.
        /// </summary>
        Common = 1,
        /// <summary>
        /// Научные
        /// </summary>
        Scientific = 2,
        /// <summary>
        /// Межличностные
        /// </summary>
        Social = 3,
        /// <summary>
        /// Прикладные
        /// </summary>
        Applied = 4,
        /// <summary>
        /// Выбор одной из способностей
        /// </summary>
        OneOf = 5
    }
}
