using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace InterviewQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            // ReverseWordOrder("Hello World!");
            // StringReverse("Lorem ipsum dolor sit amet, consectetur adipiscing elit. ");
            // Countcharacter("Lorem ipsum dolor sit amet, consectetur adipiscing elit. ");
            //removeduplicate("Lorem ipsum dolor sit amet, consectetur adipiscing elit. ");
            Fizz(100);
            // removeDuplicateWords("red white black white green yellow red red black white");


        }


        private static void Fizz(int x)
        {
            //List<int> collection = new List<int> { 1, 24, 434, 4534 };
            for (int i = 3; i <= x; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
            }
            Console.Read();


        }

        private static void ReverseWordOrder(string str)
        {
            {
                int i;
                StringBuilder reverseSentence = new StringBuilder();

                int Start = str.Length - 1;
                int End = str.Length - 1;

                while (Start > 0)
                {
                    if (str[Start] == ' ')
                    {
                        i = Start + 1;
                        while (i <= End)
                        {
                            reverseSentence.Append(str[i]);
                            i++;
                        }
                        reverseSentence.Append(' ');
                        End = Start - 1;
                    }
                    Start--;
                }
                for (i = 0; i <= End; i++)
                {
                    reverseSentence.Append(str[i]);
                }
                Console.WriteLine(reverseSentence.ToString());
                Console.Read();
            }
        }

        internal static void StringReverse(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }

            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
            Console.Read();
        }

        static void Countcharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);

            }

            Console.Read();
        }

        static void removeduplicate(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
            Console.Read();
        }

        static void removeDuplicateWords(string str)
        {
            string SetenceString = str;
            var result = string.Join(" ", SetenceString.Split(' ').Distinct());
            Console.WriteLine(result);
        }
    }
}

