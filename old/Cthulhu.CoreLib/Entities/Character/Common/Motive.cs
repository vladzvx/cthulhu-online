using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character.Common
{
    public class Motive
    {
        public long MotiveId { get; set; }
        public string MotiveName { get; set; } = string.Empty;

        public static Motive Default = new Motive()
        {
            MotiveId = 0,
            MotiveName = "Любопытство"
        };
    }
}
