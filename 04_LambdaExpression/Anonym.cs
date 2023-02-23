using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LambdaExpression
{
    public class Anonym
    {
        public static Action<int> AnonoymMethodeOutputParam = (int i) =>
        {
            //Events can be only raised in the same class.
            AnonymEvent?.Invoke("raised by an event!");
            Console.WriteLine("Das ist eine Annonyme Methode die den Wert des Mitgabeparameters ausgibt: " + i);
        };

        public static event Action<string>? AnonymEvent;
    }
}
