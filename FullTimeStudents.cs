using System;

namespace VarsityCollege
{
    public class FullTimeStudents:Students
    {
        public string Campus {get; set;}

        public FullTimeStudents()
        {

        }

        public FullTimeStudents(string id , string name, string surname, string course,string year, string campus)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Course = course;
            this.Year = year;
            this.Campus = campus;
        }

        public override string ToString()
        {
            return this.Id +" - "+ this.Name+" "+this.Surname;
        }
    }
}