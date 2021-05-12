using System;

namespace VarsityCollege
{
    public class PartTimeStudents:Students
    {
        public string OnlineTutor {get; set;}

        public PartTimeStudents()
        {

        }

        public PartTimeStudents(string id , string name, string surname, string course,string year, string onlnTutor)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Course = course;
            this.Year = year;
            this.OnlineTutor = onlnTutor;
        }

        public override string ToString()
        {
            return this.Id +" - "+ this.Name+" "+this.Surname;
        }
    }
}