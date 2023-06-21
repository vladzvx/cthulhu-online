using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character.Stats
{
    public enum StatRestoringSpec : byte
    {
        Unspec = 0,
        Never = 1,
        BetweenGame = 2,
        Nightly = 3,
    }
}
