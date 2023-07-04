using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationExceptions
{
    internal class Student
    {
        public string Name { get; set; }
        public string registratonNumber { get; set; }
        public int age { get; set; }

        public Student(string name, string registrationNumber, int age) 
        {
            this.Name = name;
            this.registratonNumber = registrationNumber;
            this.age = age;
        }

        public static Boolean ValidatingStudens(Student[] students)
        {
            for(int i=0; i<students.Length; i++)
            {
                for(int j=i+1; j<students.Length; j++)
                {
                    if (students[i].registratonNumber == students[j].registratonNumber)
                        //Write Throw message her
                        throw new SameRegistrationNumberExceptions($"The students have same registration number with student {students[i].Name} and student {students[j].Name}  ");
                }
            }
            return true;
        }
    }
}
