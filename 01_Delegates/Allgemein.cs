using System.Data;

namespace _01_Delegates
{
    public class Allgemein
    {
        //Action bekommt einen String aber gibt void zurück
        static Action<string> logMethode;
        //Hier wird ein eigener typ von delegate angelegt
        delegate float MyMethodeDelegate(string s, int number, bool isSuccess);
        static void Main(string[] args)
        {
            //Methode wird zugewiesen
            logMethode = WriteToConsole;
            //logMethode = WriteToTextfile;
            int[] data = { 1, 2, 10, 11, 12, 13, 14, };
            int[] filtered = Filter(data, IsEvenNumber);
            //Hier gelöst mit Lambda Ausdruck
            int[] filtered1 = Filter(data, (BiggerThen5) => BiggerThen5 > 5);

            logMethode(String.Join(' ', filtered1));
            
            //Nimmt int entgegen und gibt einen int
            Func<int, int, double> myCalculation = (x, y) => x + y;

            MyMethodeDelegate myMethode = (string s, int number, bool isSuccess) => 0.0f;

        }

        static double Devide(int a, int b) => (double)a / (double)b;

        //Predicate nimmt im beispiel einen int und liefert mir einen Boolean zurück
        private static int[] Filter(int[] data, Predicate<int> filterCriteria)
        {
            List<int> result = new List<int>();
            foreach(int i in data)
            {
                if(filterCriteria(i) == true)
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }

        static bool IsEvenNumber(int number)
        {
            return number % 2 == 0;
        }


        static void WriteToConsole(string text)
        {
            Console.WriteLine(text);
        }

        static void WriteToTextfile(string text)
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string fileName = Path.Combine(path, "TextFile.txt");
            System.IO.File.AppendAllLines(fileName, new String[] { text });
        }
    }
}