using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_assignment
{
    internal class human
    {
        Int32 age;
        String name, gender;

        public void setHumanInfo(Int32 a, String n, String g)
        {
            age = a;
            name = n;
            gender = g;
        }

        public Int32 getAge()
        {
            return age;
        }

        // for getting name via getter
        public String getName()
        {
            return name;
        }
        // for getting gender via getter
        public String getGender()
        {
            return gender;
        }
        public void validateCNIC ()
        {
            if(age >= 18)
            {
             Console.WriteLine("VALID FOR CNIC == YES! \n");

            }
            else
            {
                Console.WriteLine("VALID FOR CNIN == NO! \n");

            }
        }

    }
}
