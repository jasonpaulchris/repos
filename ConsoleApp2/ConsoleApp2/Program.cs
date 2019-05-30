using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    static void Main(String[] args)
    {
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++)
        {
            int age = int.Parse(Console.In.ReadLine());
            Person p = new Person(age);
            p.amIOld(age);
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses(age);
            }
            p.amIOld(age);
            Console.WriteLine();
        }
    }
}


