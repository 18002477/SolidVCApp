using System;

namespace VarsityCollege
{
    // Open closed principle, the class can be extended without being modified
    public abstract class Bursary
    {
        public abstract double Amount();
        public abstract Boolean checkAcademicEligibility();
        public abstract Boolean checkSportEligibility();
    }
}