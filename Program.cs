using System;
using System.Collections.Generic;
using System.Text;

namespace VarsityCollege
{
    // This class is strictly reseved for outputting data hence abiding to the single responsibility principle
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the VC student App");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Below are the students that are currently registered :");
            // Displaying student objects
            //StudentsObj.addStudent();

            // Writing to the textfile 
            TextFileManager.WriteToFile();
            // Reading from the textfile
            TextFileManager.ReadFromFile();
        }
    }
}
