using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Cthulhu.CoreLib.Mechanics
{
    public static class Combat
    {
        public static double CalcDamage(double attackRoll, double defence, double armor, double attackBonus, params double[] attackModifire)
        {
            var res = 0d;
            if (attackRoll + attackBonus>=defence)
            {
                res = attackModifire.Sum() - armor;
            }
            if (res<0) res = 0;
            return res;
        }

    }
}
