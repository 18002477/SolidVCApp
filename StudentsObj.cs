using System;

namespace VarsityCollege
{
    public class StudentsObj
    {
        public static void addStudent()
        {
            // Instantiating the obj & Adding a full-time student to the list
            FullTimeStudents fts1 = new  FullTimeStudents("1001","Sponge","Bob","BCAD1","1","DBN");
            StudentHelper.FullTimeList.Add(fts1);
            // Instantiating the obj Adding  a Part-time student to the list
            PartTimeStudents pts1 = new PartTimeStudents("2001","Tom","Jerry","BCOM1","2","Brad");
            StudentHelper.PartTimeList.Add(pts1);

            foreach(FullTimeStudents ft in StudentHelper.FullTimeList)
            {
                Console.WriteLine("Full-Time Students");
                Console.WriteLine(ft.ToString());
                Console.WriteLine("------------------------------------------------------");
            }
            foreach(PartTimeStudents pt in StudentHelper.PartTimeList)
            {
                Console.WriteLine("Part-Time Students");
                Console.WriteLine(pt.ToString());
            }
        }
    }
}