using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Cthulhu.CoreLib.Mechanics
{
    public static class Common
    {

        public static double Check(double targetValue, double rollResult, double checkBonus)
        {
            return rollResult + checkBonus - targetValue;
        }

        public static double Roll()
        {
            return RandomNumberGenerator.GetInt32(1, 7);
        }
    }
}
