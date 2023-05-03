using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    // EX2a) mettre en abstract
    public abstract class Animal
    {
        public string Name { get; private set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public object Age { get; internal set; }

        public Animal()
        {
            Name = "Cat";
            Type = "commun";
            Id = 1;
        }

        public Animal(string name, string type, int id, int age)
        {
            Name = name;
            Type = type;
            Id = id;

        }

        public Animal(string name)
        {
            Name = name;
        }

        public Animal(string name, string type, int id) : this(name)
        {
        }

        public virtual void Move()
        {
            Console.WriteLine("Animal is moving");
        }

        //EX3a) Override de la méthode Move et ajout de new pour Sleep
        public new void Sleep()
        {
            Console.WriteLine("ZZZ..zzz");
        }
    }
}

