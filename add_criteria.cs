using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_assignment
{
    internal class add_criteria
    {
        Int32 math,physic,chemistry,total;

        public void setMarks(Int32 m, Int32 p, Int32 c)
        {
            math = m;
            physic = p;
            chemistry = c;

            // FOR VALIDATE
            if (math + physic + chemistry >= 180)
            {
                Console.WriteLine("ADMISSION ELIGIBLE !");
            }
            else if (physic + math >= 140)
            {
                Console.WriteLine("ADMISSION ELIGIBLE !" );
            }
            else
            {
                Console.WriteLine("ADMISSION NOT ELIGIBLE!");
            }
        }



    }
}
