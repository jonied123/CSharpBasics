using _01_Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DelegatesUndEvents
{
    public class Program
    {
        static void Main(string[] args)
        {
            Events events = new Events();
            events.OnLogAction += Generator_OnLog;
            events.OnLogAction += (text) => Console.WriteLine("2. Registrierung " + text);
            events.Test();
        }

        private static void Generator_OnLog(string obj)
        {
            Console.WriteLine(obj);
        }
    }
}
