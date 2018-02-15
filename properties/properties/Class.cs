using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace properties
{
    public class Class
    {
        Person p = new Person();
        p.Age = 23;
    }

    public class Person
    {
        public int Age;
    }
}
