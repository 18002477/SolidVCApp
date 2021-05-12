using System;

namespace VarsityCollege
{
    public abstract class LeadershipAward:Bursary
    {
        // Logic
        public double TuitionCost {get; set;}
        public override double Amount()
        {
            return TuitionCost * 0.5;
        }
    }
}