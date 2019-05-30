using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class SingleInstance
    {
        private int value = 10;
        //in the case of singleton pattern, we make our ctor private to avoid instantiating the object using the new keyword
        private SingleInstance() { }

        //the static method acts as a mechanism to expose the internal instance
        public static SingleInstance Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        private class Nested
        {
            static Nested() { }
            internal static readonly SingleInstance instance = new SingleInstance();
        }

        public void Increment()
        {
            value++;
        }
        public int Value { get { return value; } }


    }

    public class SingletonExample
    {
        public static void Main(String[] args)
        {
            SingleInstance t1 = SingleInstance.Instance;
            SingleInstance t2 = SingleInstance.Instance;
            t1.Increment();
            if (t1.Value == t2.Value)
                Console.WriteLine("SingletonObject");
        }
    }
}
