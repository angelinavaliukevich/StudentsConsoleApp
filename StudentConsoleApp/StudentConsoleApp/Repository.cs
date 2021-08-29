using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
    class Repository
    {
        
        private byte NextId { get; set; }
        public int Id { get; private set; }

        public Student[] students = new Student[10];
        private int nextId = 1;
        public int Add(Student student)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                        student.Id = nextId;
                    
                     return nextId++;
                    students[i] = student;
                    return i;
                }              
            }
            return 0;
        }
        public int Delete(Student student)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i]?.Id == Id)
                {
                    students[i].Id = 0;
                }
                return students[i].Id;
                students[i] = student;
                return i;

            }
        }
        public int Edit(Student student)
        {

        }


       