using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_StudentMgmtSystem
{
    public class Student
    {
        // fields
        public static int NextId = 1;
        public int StudentID { get;}
        public string StudentName { get; }
        public Programs ProgramEnroled { get; set; }

        // constructor take studentName as input
        public Student(string studentNme)
        {
            StudentID = NextId;
            NextId++;
            StudentName = studentNme;
        }
    }
}
