using System;
using System.Collections.Generic;
using System.Text;

namespace class_library
{
    class ConsolePrinter : IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
       
    }
}
