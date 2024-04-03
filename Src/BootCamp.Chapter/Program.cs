﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = AskName("Enter Full Name: ");
            int age = AskAge(name);
            float weight = AskStats("Enter " + name + "'s weight in kg: ");
            float height = AskStats("Enter " + name + ",s height in m: ");
            float BMI = CalcBMI(weight, height);
            Console.WriteLine("Name: "+name+", Age: " + age + ", Weight: " + weight+", Height: "+height+",BMI: "+BMI);
                

        }
        public static string AskName(string message)
        {
            Console.Write(message);
            string name = Console.ReadLine();
            return name;

        }

        public static int AskAge(string name)
        {
            Console.Write("Enter " + name + "'s age: ");
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
