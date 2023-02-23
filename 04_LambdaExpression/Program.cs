using System.Timers;

namespace _04_LambdaExpression
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            Anonym.AnonymEvent += (string s) =>
            {
                Console.WriteLine("Performed by an anonym methode message, " + s);
            };
            Anonym.AnonoymMethodeOutputParam(1);

            System.Console.WriteLine();


            Func<string, string> square = x => x;
        }


        public string MyMethode(string s) => $"Message: {s}";
    }
}