using Cthulhu.CoreLib.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Cthulhu.CoreLib.Entities.Character
{
    public class Checkup
    {
        public CheckupStatus Status { get; private set; }
        public double Threshold { get; private set; }
        public double RollResult { get; private set; }
        public double PointsAdded { get; private set; }

        public Checkup(double threshold, double pointsAdded)
        {
            Threshold = threshold;
            PointsAdded = pointsAdded;
        }

        public CheckupStatus Execute()
        {
            RollResult = (double)RandomNumberGenerator.GetInt32(1, 7);
            Status = RollResult + PointsAdded >= Threshold ? CheckupStatus.Success : CheckupStatus.Fail;
            return Status;
        }
    }
}
