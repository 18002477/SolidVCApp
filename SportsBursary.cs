using System;
using System.Text;

namespace VarsityCollege
{
    public abstract class SportsBursary:Bursary
    {
        // Logic
        string Rep ="";
        public override Boolean checkSportEligibility()
        {
            if(Rep == "Provincial" || Rep == "National")
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