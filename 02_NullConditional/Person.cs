using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NullConditional
{
    public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        //Konstruktor
        public Person(int id, string firstname, string lastname) 
        { 
            Id= id;
            Firstname = firstname;
            Lastname = lastname;
        }

        public string toString()
        {
            return $"{nameof(Firstname),-10} {Id}\n{nameof(Lastname),-10} {Firstname}\n{nameof(Lastname),10} {Lastname}";
        }
    }
}
