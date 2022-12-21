namespace _03_InterpolationString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // ***************String Interpolation Example********************
            //String name = "Jonas";
            //Console.WriteLine($"Hello, {name}. It's a pleasure to meet you!");

            // ***************String Interpolation Example with tuple********************
            //var item = (Name: "eggplant", Price: 1.99m, perPackage: 3);
            //var date = DateTime.Now;
            //Console.WriteLine($"On {date:t}, the price of {item.Name} was {item.Price:F3} per {item.perPackage} items.");


            // ***************String Interpolation Example with Spacing********************
            //var inventory = new Dictionary<string, int>()
            //{
            //    ["hammer, ball pein"] = 18,
            //    ["hammer, cross pein"] = 5,
            //    ["screwdriver, Phillips #2"] = 14
            //};

            //Console.WriteLine($"Inventory on {DateTime.Now:d}");
            //Console.WriteLine(" ");
            //Console.WriteLine($"|{"Item",-25}|{"Quantity",10}|");
            //foreach (var item in inventory)
            //    Console.WriteLine($"|{item.Key,-25}|{item.Value,10}|");

            // ***************String Interpolation Example combine spacing and formatting********************
            Console.WriteLine($"[{DateTime.Now,-20:d}] Hour [{DateTime.Now,-10:HH}] [{1063.342,15:N2}] feet");
        }
    
    }
}