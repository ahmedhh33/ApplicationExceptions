using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationExceptions
{
     internal class SameRegistrationNumberExceptions : ApplicationException
    {
        Student A { get; set; }
        Student B { get; set; }

        public SameRegistrationNumberExceptions(Student A, Student B)
        {
            this.A = A;
            this.B = B;
        }
        public override string ToString()
        {
           return $"{A.Name} and {B.Name} have same registration number with student ";
        }
    }
}
