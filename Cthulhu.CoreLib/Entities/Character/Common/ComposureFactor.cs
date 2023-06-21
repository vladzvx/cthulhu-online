using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character.Common
{
    public class ComposureFactor : Person
    {
        /// <summary>
        /// Кем является для сыщика данный персонаж (друг, дядя и т.д.)
        /// </summary>
        public string Role { get; set; } = string.Empty;
    }
}
