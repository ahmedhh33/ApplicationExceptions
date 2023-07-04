using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicationExceptions
{
    public class SameRegistrationNumberExceptions:ApplicationException
    {
        public SameRegistrationNumberExceptions(string? message):base(message) 
        {

        }

    }
}
