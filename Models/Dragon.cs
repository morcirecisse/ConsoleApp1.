using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    // Ex2b) creer la classe Dragon
    internal class Dragon : Animal
    {
        public Dragon(string name, string type, int id, int age) : base(name, type, id)
        {
            Age = age;
        }

        public int Age { get; set; }

        public override void Move()
        {
            Console.WriteLine($"{Name} is flying and breathing fire!");
        }

        public new void Sleep()
        {
            Console.WriteLine("Don't wake up the dragon!");
        }

        public void Moov()
        {
            Console.WriteLine("The dragon is moving!");
        }
    }
}