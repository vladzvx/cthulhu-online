using Cthulhu.CoreLib.Entities.Character.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character.Stats
{
    public class StatValue
    {
        public long StatId { get; set; }
        public double MaxValue { get; set; }
        public double CurrentValue { get; set; }
        public bool IsProfessional { get; set; }
        public StatType Type { get; set; }
        public StatRestoringSpec RestoringSpec { get; set; }

        public void NormalizeValues()
        {
            if (MaxValue<0) MaxValue = 0;
            if (CurrentValue<0) CurrentValue = 0;
            if (CurrentValue > MaxValue) CurrentValue = MaxValue;
        }

        public void Restore(RestorationMod restorationMod)
        {
            CurrentValue += Math.Ceiling((MaxValue - CurrentValue) / (int)restorationMod);
            NormalizeValues();
        }
    }
}
