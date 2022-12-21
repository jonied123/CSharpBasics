namespace _02_NullConditional
{
    public class Program
    {
        static void Main(string[] args)
        {
            Parent p1 = new Parent(10, "Hans", "Wurst", "male");
            Console.WriteLine(p1.Child?.Firstname);

            Child Elli = new Child(01, "Elli", "Van Bever");
            Elli.GoAndPlay();
            Elli.action();
            Elli.TellYourName();
        }
    }
}