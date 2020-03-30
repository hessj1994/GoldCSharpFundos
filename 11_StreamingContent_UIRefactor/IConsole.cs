using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StreamingContent_UIRefactor
{
    public interface IConsole
    {
        void WriteLine(string s);
        void WriteLine(object o);
        void Write(string s);
        void Clear();
        //Take in user input
        string ReadLine();
        ConsoleKeyInfo ReadKey(); //Test UI logic, take out need to implement console

    }
}
