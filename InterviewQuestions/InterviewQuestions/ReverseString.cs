using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewQuestions
{
    class ReverseString
    {
        static void StringReverse(string str)
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length; i < j;  i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }

            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }
    }
}
