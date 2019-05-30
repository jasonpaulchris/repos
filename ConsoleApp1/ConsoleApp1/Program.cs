using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{ 
     class Program
    {
        static void Main(string[] args)
        {

            //Operation op = num => { Console.WriteLine("{0} x 2 = {1}", num, num * 2); };
            Action<int> op = num => { Console.WriteLine("{0} x 2 = {1}", num, num * 2); };
            op(2);
        }
    }
}
