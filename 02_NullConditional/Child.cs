using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace _02_NullConditional
{
    public class Child : Person
    {

        public Action action;

        public Child(int id, string firstname, string lastname) : base(id, firstname, lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
            action = GoAndPlay;
        }


        public void GoAndPlay()
        {
            Console.WriteLine("Okay Dady im going playing!");
        }

        public void TellYourName()
        {
            Console.WriteLine("My Name is: " + base.Firstname);
        }


    }
}
