using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
    class Student
    {
        private string name;
        private string surname;
        private int age;
        private string gendet;

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public Student(int v, string v1, string v2, string v3, int v4) { }
        public Student(string name, string surname, int age, string gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
        public int Id { get; internal set; }
        public void Update(Student student)
        {

        }
    }
}
