using System;
using System.IO;

namespace VarsityCollege
{
    public class TextFileManager
    {
        public static void ReadFromFile()
        {
            String line ="";
            try
            {
                //Passing the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("C:\\VarsityCollege.txt");
                //Reading the first line of text
                //line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        public static void WriteToFile()
        {
            try
            {
                // Instantiating the obj & Adding a full-time student to the list
                FullTimeStudents fts1 = new  FullTimeStudents("1001","Sponge","Bob","BCAD1","1","DBN");
                StudentHelper.FullTimeList.Add(fts1);
                // Instantiating the obj Adding  a Part-time student to the list
                PartTimeStudents pts1 = new PartTimeStudents("2001","Tom","Jerry","BCOM1","2","Brad");
                StudentHelper.PartTimeList.Add(pts1);
                //Passing the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\VarsityCollege.txt");
                
                //Write a line of text
                foreach(FullTimeStudents ft in StudentHelper.FullTimeList)
                {
                    sw.WriteLine("Full-Time Students");
                    sw.WriteLine(ft);
                }
                 foreach(PartTimeStudents pt in StudentHelper.PartTimeList)
                {
                    sw.WriteLine("Part-Time Students");
                    sw.WriteLine(pt);
                }
                //Closing the file
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}