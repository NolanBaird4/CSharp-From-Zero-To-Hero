using System;
using System.Collections.Generic;
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
            Console.WriteLine("Name: " + name + ", Age: " + age + ", Weight: " + weight + ", Height: " + height + ",BMI: " + BMI);

        }

        public static string AskName(string message)
        {
            Console.Write(message);
            string name = Console.ReadLine();
            return name;

        }

        public static int AskAge(string message)
        {
            Console.Write(message);
            string ageS = Console.ReadLine();
            int ageI = int.Parse(ageS);
            return ageI;
        }

        public static float AskStats(string message)
        {
            Console.Write(message);
            string stat = Console.ReadLine();
            float statD;
            statD = float.Parse(stat, System.Globalization.NumberStyles.AllowDecimalPoint);
            return statD;

        }

        public static float CalcBMI(float weight, float height)
        {
            float BMI = weight / height / height;
            return BMI;
        }
    }
}
