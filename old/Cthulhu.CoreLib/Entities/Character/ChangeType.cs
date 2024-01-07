using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character
{
    public enum ChangeType: byte
    {
        AddProfessional = 0,
        RemoveProfessional = 1,
        DistributeValue = 2,
        UndistributeValue = 3,

        UseSkill = 4,
        RefreshSkill= 5,

        SpentValue = 6,
        RestoreValue = 7
    }
}
