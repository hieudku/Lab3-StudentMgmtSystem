using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_StudentMgmtSystem
{
    public class Programs
    {
        // fields
        public string programName { get; }
        public  readonly int maxEnrolment = 30;
        public int currentEnrolment { get; set; }

        public  readonly int MaxPrograms = 10;
        
        // constructor
        public Programs(string programName)
        {
            this.programName = programName;
        }
    }
}
