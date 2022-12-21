using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NullConditional
{
    public class Parent : Person
    {
        public string Sex;
        public Child? Child;
        public Parent(int id, string firstname, string lastname, string sex, Child child) : base(id, firstname, lastname)
        {
            Sex = sex;
            this.Child = child;
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }
        public Parent(int id, string firstname, string lastname, string sex) : base(id, firstname, lastname)
        {
            Sex = sex;
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }

        public string toString()
        {
            return $"base.toString()";
        }

    }
}
