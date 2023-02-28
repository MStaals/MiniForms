using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniForms
{
    public class ExampleClass
    {
        // Property
        public string Name { get; set; }

        // Field
        private string pinCode;

        // Method zonder argumenten/parameters en zonder return type
        public void Foo()
        {

        }

        // Method zonder argumenten/parameters en met return type int
        public string Bar() 
        {
            return "1";
        }

        // Method met argument/parameter zonder return type.
        public void FooFoo(string name)
        {

        }

        public static int Sum(int x, int y)
        {
            return x + y;
        }


    }
}
