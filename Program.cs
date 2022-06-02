using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            human hInfo = new human();

            Int32 age;
            String name, gender;

            Console.WriteLine("ENTER AGE--");

            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER NAME--");

            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("ENTER GENDER--");

            gender = Convert.ToString(Console.ReadLine());

            hInfo.setHumanInfo(age,name,gender);

            Console.WriteLine(hInfo.getAge());
            Console.WriteLine(hInfo.getName());
            Console.WriteLine(hInfo.getGender());

            Console.ReadKey();
        }
    }
}
