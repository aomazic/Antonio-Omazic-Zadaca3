using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace class_library
{
    class FilePrinter : IPrinter
    {
        public string Filename { get; private set; }
        public FilePrinter(string filename)
        {
            Filename = filename;
        }

        public void Print(string message)
        {
            File.WriteAllText(Filename, message);

        }
    }
}
