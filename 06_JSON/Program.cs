using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace _06_JSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Configuration configuration = Project.CreateConfiguration();

            string path = "C:\\Users\\Edlejo\\Desktop\\JSONSerialization\\JSONTest.json";

            SerializationClass1 SerializationClass = new SerializationClass1()
            {
               SerializationClass2= new SerializationClass2()
               {
                   Id= 1,
                   Firstname ="Dave",
                   Lastname = "Dev"
               }
            };

            string text = JsonConvert.SerializeObject(SerializationClass);

            File.WriteAllText(path, text);

        }
    }
}