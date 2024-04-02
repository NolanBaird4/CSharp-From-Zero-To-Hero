using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string unitsW = "kg";
            string unitsH ="cm"; 
            double BMI = 0;

            Console.Write("Enter Full Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter "+name+"'s age: ");
            string age = Console.ReadLine();

            Console.Write("Choose units - enter lbs/in, kg/m, or kg/cm: ");
            string units = Console.ReadLine();

            if (string.Equals(units, "lbs/in"))
            {
                unitsW = "lbs";
                unitsH = "in";
            }
            else if (string.Equals(units, "kg/m"))
            {
                unitsW = "kg";
                unitsH = "m";
            }
            else if (string.Equals(units, "kg/cm"))
            {
                unitsW = "kg";
                unitsH = "cm";
            }
            else
            {
                Console.Write("Defaulting to kg/cm");
            }            

            Console.Write("Enter " + name + "'s weight in " + unitsW + ": ");
            string weight = Console.ReadLine();
            double weightD;
            weightD = double.Parse(weight, System.Globalization.NumberStyles.AllowDecimalPoint);

            Console.Write("Enter " + name + "'s height in " + unitsH + ": ");
            string height = Console.ReadLine();
            double heightD;
            heightD = double.Parse(height, System.Globalization.NumberStyles.AllowDecimalPoint);

            if (string.Equals(units, "lbs/in"))
            {
                BMI = weightD / Math.Pow((heightD), 2)*703;
            }
            else if (string.Equals(units, "kg/m"))
            {
                BMI = weightD / Math.Pow((heightD), 2);
            }
            else if (string.Equals(units, "kg/cm"))
            {
                BMI = weightD / Math.Pow((heightD / 100), 2);
            }

            BMI = Math.Round(BMI, 2);
            Console.WriteLine(name + "'s BMI is :" + BMI);
            
            
        }
    }
}
