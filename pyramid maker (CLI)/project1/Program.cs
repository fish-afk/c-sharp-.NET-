﻿using System;

namespace project1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input;
            string age;


            Console.WriteLine("Whats your name?");
            input = Console.ReadLine();

            Console.WriteLine("\nWhats your age/");
            age = Console.ReadLine();



            Console.WriteLine("\n Hey " + input);
            Checker(Convert.ToInt32(age));


            int pyramid_height;

            Console.WriteLine("\nWant to see a pyramid? \n Enter a random number above 10 ->");
            pyramid_height = Convert.ToInt32(Console.ReadLine());


            Draw_pyramid(pyramid_height);

            Greeting();
            Console.ReadKey();
        }

        public static void Greeting()
        {
            Console.WriteLine("\n There we go...");
        }

        public static void Checker(int ages)
        {

            if(ages > 100)
            {
                Console.WriteLine("\nyou're way too old");
            }
            else if(ages < 100)
            {
                Console.WriteLine("\nyou are " + ages + " yrs old..");
            }
        }

        public static void Draw_pyramid(int height)
        {

            for (int j = 1; j <= height; j++)
            {
                height -= 1;
                string result = string.Join(" ", new string[height]);
                result += string.Join("*", new string[j]);

                result += string.Join("*", new string[j - 1]);
                Console.WriteLine(result);
                   
            }
            
        }
    }
}
