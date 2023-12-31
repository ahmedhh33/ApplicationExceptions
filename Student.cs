﻿using System;
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

        public static Boolean ValidatingStudens(Student[] students)//just throw exceptions
        {
            for(int i=0; i<students.Length; i++)
            {
                for(int j=i+1; j<students.Length; j++)
                {
                    if (students[i].registratonNumber == students[j].registratonNumber)
                        //Write Throw message here
                        throw new SameRegistrationNumberExceptions( students[i], students[j]);
                }
            }
            return true;
        }
        public static Boolean Validate (Student[] student)
        {
            return ValidatingStudens(student);
        }
        public static Boolean methade1 (Student[] student)
        {
            return Validate(student);
        }
        public static Boolean methode2(Student[] student)//handeling method
        {
            try
            {
                return methade1(student);
            }catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }
    }
}
