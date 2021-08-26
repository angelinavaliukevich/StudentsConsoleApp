using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentConsoleApp
{
    class Repository
    {
        public Student[] students = new Student[10];

        public int Add(Student student)
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    students[i] = student;
                    return i;
                }              
            }
            return 0;
        }

        internal string Delete()
        {
            throw new NotImplementedException();
        }
        internal string Edit()
        {
            throw new NotImplementedException();
        }
        internal string Get()
        {
            throw new NotImplementedException();
        }
    }
}