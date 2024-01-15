using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class ElectricityBill
    {
        public static void Main()
        {
            Console.WriteLine("Enter your ID Number : ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Units consumed : ");
            int unit = int.Parse(Console.ReadLine());

            displayDetails(id, name, unit);
        }

        static void displayDetails(int id, string name, int unit)
        {
            Console.WriteLine("User id is : "+id);
            Console.WriteLine("User name is : "+ name);
            Console.WriteLine("Amount of unit consumed : " + unit);
            double unitcharges;


            if (unit < 200)
            {
                unitcharges = unit * 1.20;
                Console.WriteLine("Amount Charges @Rs. 1.20 per unit : " + unitcharges);
            }
            else if (unit < 400)
            {
                unitcharges = unit * 1.50;
                Console.WriteLine("Amount Charges @Rs. 1.50 per unit : " + unitcharges);
            }
            else if (unit < 600)
            {
                unitcharges = unit * 1.80;
                Console.WriteLine("Amount Charges @Rs. 1.80 per unit : " + unitcharges);
            }
            else
            {
                unitcharges = unit * 2.00;
                Console.WriteLine("Amount Charges @Rs. 2.00 per unit : " + unitcharges);
            }

            double totalCharge;
            if(unitcharges > 400)
            {
                double surchage = (unitcharges * 0.15);
                Console.WriteLine("Surchage Amount : " + surchage);
                totalCharge = unitcharges + surchage;

                Console.WriteLine("Net amount paid by the customer : " + totalCharge);
            }
        }
    }
}
