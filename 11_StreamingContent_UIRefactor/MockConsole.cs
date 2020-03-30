using _11_StreamingContent_UIRefactor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_StreamingContent_UIRefactor
{
    public class MockConsole : IConsole
    {
        public Queue<string> UserInput;
        public string Output;

        public MockConsole(IEnumerable<string> input)
        {
            UserInput = new Queue<string>(input);
            Output = "";//showing something was called
        }

        public void Clear()
        {
            Output += "Called Clear Method \n";
        }

        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }

        public string ReadLine()
        {
            return UserInput.Dequeue();
        }

        public void Write(string s)//does not expect a break, writing to show output
        {
            Output += s + "\n";
        }

        public void WriteLine(object o)
        {
            Output += o + "\n";
        }
    }
}
