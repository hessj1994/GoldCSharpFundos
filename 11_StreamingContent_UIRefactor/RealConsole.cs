using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StreamingContent_UIRefactor
{
    public class RealConsole : IConsole
    {
        public void Clear()
        {
            Console.Clear();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return Console.ReadKey();
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string s)
        {
            Console.Write(s);
        }

    }
}
