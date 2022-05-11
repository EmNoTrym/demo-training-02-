using System;
using System.Collections.Generic;
using System.Text;

namespace test_t4
{
    class Person
    {
        private string name { get; set; }
        private int age { get; set; }

        Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string older(Person a)
        {
            if (a.age > this.age)
            {
                return a.name;
            }

            else
            {
                return this.name;
            }
        }

        public string younger(Person a)
        {
            if (a.age > this.age)
            {
                return this.name;
            }

            else
            {
                return a.name;
            }
        }
    }
}
