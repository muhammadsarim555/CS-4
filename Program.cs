using System;

namespace lab2_assignment
{
    internal class Program
    {



        static void avrNumbers()
        {
            Int32  numberOfInputs ;
            Double  sum= 0;

            Console.WriteLine("How many numbers do you want to input?");
            numberOfInputs = Convert.ToInt32(Console.ReadLine());

            Double[] avr_num = new Double[numberOfInputs];


            for (Int32 i = 0; i < numberOfInputs; i++)
            {
                avr_num[i] = Double.Parse(Console.ReadLine());
            }

            for (Int32 l = 0; l < numberOfInputs; l++)
            {
               sum = sum + avr_num[l];
            }

            Console.WriteLine("Total Sum === " + sum);
            Console.WriteLine("Total Sum === " + sum / numberOfInputs);
        }

        static void Main(string[] args)
        {
            human hInfo = new human();
            add_criteria addmissionCritiria = new add_criteria();


            // FOR QUESTION 1
            Int32 age;
            String name, gender;

            // FOR QUESTION 2 VARIABLES
            Int32 math, phy, chem;


            Console.WriteLine("ENTER AGE--");

            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER NAME--");

            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("ENTER GENDER--");

            gender = Convert.ToString(Console.ReadLine());

            hInfo.setHumanInfo(age, name, gender);



            hInfo.validateCNIC();

            Console.WriteLine("\n QUESTION # 2 \n");

            Console.WriteLine("ENTER MATH MARKS --");

            math = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER CHEMISTRY MARKS--");

            chem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER PHYSICS MARKS--");

            phy = Convert.ToInt32(Console.ReadLine());


            addmissionCritiria.setMarks(math, phy, chem);

            Console.WriteLine("Question # 3 == \n");
            avrNumbers();



            Console.ReadKey();
        }
    }
}
