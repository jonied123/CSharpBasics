using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegates
{
    public class Events
    {
        //public delegate void TextDelegateHandler(string text);
        //public event TextDelegateHandler OnLog;
        //Hier ist ein Delegate das ein event ist
        public event Action<string> OnLogAction;
        public Func<String> OnLogFunc;
        public Predicate<string> OnLogPredicate;

        public void Test()
        {
            OnLogAction?.Invoke("Hier habe ich meine Test Methode");
        }
    }
}
