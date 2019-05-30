using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        public int age;
        public Person(int initialAge)
        {
            if (!(age > 0))
            {
                age = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
            age = initialAge;

        }
        public void amIOld(int age)
        {
            if (age < 13 && age > 0)
            {
                Console.WriteLine("You are young.");
            }
            if (age >= 14 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }
        }

        public void yearPasses(int age)
        {
           age += 1;
        }
    }
}

