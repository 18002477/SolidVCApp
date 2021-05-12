using System;

namespace VarsityCollege
{
    public abstract class Academic:Bursary
    {
        // This class makes use of the interface segregation principle the client is not forced to implement an interface it does not use
        // Remember to change to interface class
        public double TuitionCost {get; set;}
        public double discount {get; set;}
        public double ovrAvrg {get; set;}

        public override double Amount()
        {
            return TuitionCost - discount;
        }
       
        public override Boolean checkAcademicEligibility()
        {
            if(ovrAvrg >= 80)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}