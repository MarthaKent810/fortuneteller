using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortuneteller
{
    class Program
    {
        static void Main(string[] args)
        {
            //name variables
            string firstname;
            string lastname;
            int age = 0;
            int month = 0;
            string color = "";
            int numbsibs = 0;
            int yrsretire = 0;
            string vachome = "";
            string money = "";
            string transport = "";

            //Obtain user input
            Console.WriteLine("Please enter your first name");
            firstname = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            lastname = Console.ReadLine();
            Console.WriteLine("How old are you?");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the number of the month in which you were born");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your favorite color from the ROYGBIV rainbow spectrum or type HELP");
            color = Console.ReadLine().ToLower();

            //help menu
            switch (color)
            {
                case "red":
                    break;

                case "orange":
                    break;

                case "yellow":
                    break;

                case "green":
                    break;

                case "blue":
                    break;

                case "indigo":
                    break;

                case "violet":
                    break;

                default:
                    Console.WriteLine("Please enter one: red, orange, yellow, green, blue, indigo, violet");
                    Console.ReadLine().ToLower();
                    break;
            }
            Console.WriteLine("And how many siblings do you have?");
            numbsibs = int.Parse(Console.ReadLine());

            //Assign values to input
            if (age % 2 == 0)
            {
                yrsretire = 15;
            }
            if (age % 2 == 1)
            {
                yrsretire = 22;
            }
            if (month >= 1 && month <= 4)
            {
                money = ("$250,000.00");
            }
            if (month >= 5 && month <= 8)
            {
                money = ("$2,000,000.00");
            }
            if (month >= 9 && month <= 12)
            {
                money = ("$50.00");
            }
            if (month < 0 || month > 12)
            {
                money = ("$0.00");
            }
            if (numbsibs == 0)
            {
                vachome = ("Tuscany");
            }
            if (numbsibs == 1)
            {
                vachome = ("Paris");
            }
            if (numbsibs == 2)
            {
                vachome = ("Costa Rica");
            }
            if (numbsibs == 3)
            {
                vachome = ("Tampa");
            }
            if (numbsibs > 3)
            {
                vachome = ("Cape Cod");
            }
            if (numbsibs < 0)
            {
                vachome = ("Paducah");
            }
            if (color == "red")
            {
                transport = ("Corvette");
            }
            if (color == "orange")
            { 
                transport = ("Jeep");
            }
            if (color == "yellow")
            {
                transport = ("Mustang");
            }
            if (color == "green")
            {
                transport = ("motorcycle");
            }
            if (color == "blue")
            {
                transport = ("Honda");
            }
            if (color == "indigo")
            {
                transport = ("linousine");
            }
            if (color == "violet")
            {
                transport = ("Cadillac");
            }
            //print fortune
            Console.WriteLine((firstname) + (" ") + (lastname) + (" will retire in ") + (yrsretire) + (" years with ") + (money) + (" in the bank, a vacation home in ") + (vachome) + (", and a  ") + (transport) + ("."));




        }
    }
}
