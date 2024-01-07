using Cthulhu.CoreLib.Entities.Character.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character.Stats
{
    public class StatValue : Stat
    {
        public double MaxValue { get; set; }
        public double CurrentValue { get; set; }
        public bool IsProfessional { get; set; }

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

        public StatValue(Stat stat, bool isProfessional = false)
        {
            MaxValue = 0;
            CurrentValue = 0;
            IsProfessional = isProfessional;
            //StatId = stat.StatId;
            //Type = stat.Type;
            //RestoringSpec = stat.RestoringSpec;
            //Name = stat.Name;
        }
    }
}
