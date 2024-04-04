using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson3
    {
        static void main(string[] args)
        {
            Lesson3.Demo();
        }


        public static void Demo()
        {
            string name = AskName("Enter Full Name: ");
            int age = AskAge("Enter " + name + "'s age: ");
            float weight = AskStats("Enter " + name + "'s weight in kg: ");
            float height = AskStats("Enter " + name + ",s height in m: ");
            float BMI = CalcBMI(weight, height);


        }

        public static string AskName(string message)
        {
            Console.Write(message);
            string name = Console.ReadLine();
            bool invalidName = string.IsNullOrWhiteSpace(name);
            if (invalidName)
            {
                Console.WriteLine("Name cannot be empty.");
                return "-";
            }
            return name;
        }

        public static int AskAge(string message)
        {
            Console.Write(message);
            string ageS = Console.ReadLine();
            var isNumber = int.TryParse(ageS, out var age);

            if (!isNumber)
            {
                Console.WriteLine("\"" + ageS + "\" is not a valid number.");
                return -1;
            }
            return age;
        }

        public static float AskStats(string message)
        {
            Console.Write(message);
            string stat = Console.ReadLine();

            var isNumber = float.TryParse(stat, out var statP);

            if (!isNumber)
            {
                Console.WriteLine("\""+stat + "\" is not a valid number.");
                return -1;
            }

            float statD = float.Parse(stat, System.Globalization.NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
            return statD;

        }

        public static float CalcBMI(float weight, float height)
        {
            if (weight <= 0 || height <= 0)
            {
                Console.WriteLine("Failed calculating BMI. Reason:");
                if (weight <= 0)
                {
                    Console.WriteLine("Weight cannot be equal or less than zero, but was " + weight + ".");

                }
                if (height <= 0)
                {
                    Console.WriteLine("Height cannot be equal or less than zero, but was " + height + ".");

                }
                return -1;
            }
            float BMI = weight / height / height;
            return BMI;
        }
    }
}
