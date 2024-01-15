using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class Eligibilty
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your number in Maths : ");
            int math = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your number in Physics : ");
            int phy = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your number in Chemistry : ");
            int chem = int.Parse(Console.ReadLine());

            int totalSum = math + phy + chem;
            int MathPhySum = math + phy;

            if(totalSum > 180)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else if(MathPhySum > 140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else {
                Console.WriteLine("You are not eligible.");
            }
        }
    }
}
