﻿using System;

namespace quiz1
{
    class Quiz1
    {
        static void Main(string[] args)
        {
            string p1 = "point";
            string p2 = "points";
            Console.WriteLine("what is 9+10");
            int a = Convert.ToInt16(Console.ReadLine());
            int b = 0;
            if (a == 19)
            {
                b += 1;
                Console.WriteLine("good job now u have " + b + " " + p1);
            }
            else
            {
                if (a != 19)
                    b -= 1;
                Console.WriteLine("nah now u have " + b + " " + p2);
            }

            Console.WriteLine("what is 6+5");
            int c = Convert.ToInt16(Console.ReadLine());

            if (c == 11)
            {
                b += 1;
                if (b > 1)
                {
                    Console.WriteLine("good job now u have " + b + " " + p2);
                }
                else
                    if (b == 1 || b == 0 || b == -1)
                {
                    Console.WriteLine("good job now u have " + b + " " + p1);

                }
                else
                    if (b < -1)
                    {
                    Console.WriteLine("good job now u have " + b + " " + p2);
                    }
            }
            if (c != 11)
            {
                b -= 1;
                if (b > 1)
                {
                    Console.WriteLine("nah now u have " + b + " " + p2);
                }
                else
                    if (b == 1 || b == 0 || b == -1)
                {
                    Console.WriteLine("nah now u have " + b + " " + p1);
                }
                else
                    if (b < -1)
                    {
                        Console.WriteLine("nah now u have " + b + " " + p2);
                    }



            }
            Console.WriteLine("Press any Key to Exit...");
            Console.ReadKey();

        }
    }

}