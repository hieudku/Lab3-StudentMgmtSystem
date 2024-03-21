using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_StudentMgmtSystem
{
    public class EnrolmentManager
    {
        public static void EnrollStudent(Student student, Programs programs, ref int availableSlots)
        {
            if (programs.currentEnrolment < programs.maxEnrolment)
            {
                student.ProgramEnroled = programs;
                programs.currentEnrolment++;
                availableSlots--;

                Console.WriteLine($"Student {student.StudentName} has been enrolled " +
                    $"into {programs.programName} program");
            }
            else
            {
                throw new InvalidOperationException("The program is full, can not enroll student!");
            }
        }
        public static void GetAvailableSlots(Programs programs, out int availableSlots)
        {
            availableSlots = programs.currentEnrolment - programs.maxEnrolment;
        }
    }
}
