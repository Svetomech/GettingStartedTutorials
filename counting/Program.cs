﻿using System;

namespace GettingStartedTutorials.CSharp.LoopingFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; ++i)
            {
                for (int j = 0; j <= 24; j += i)
                {
                    Console.Write(j != 24 ? j + "," : j + ".");
                }
                Console.WriteLine();
            }
        }
    }
}
