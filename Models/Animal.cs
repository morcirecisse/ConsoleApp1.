using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal abstract class Animal
    {
        // Etape 2: ajouter une propriété Name
        public string Name { get; set; }

        // Etape 3: ajouter des méthodes Moove et Sleep
        public void Moove()
        {
            Console.WriteLine("Moove");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleep");
        }

        // Etape 4: ajouter deux constructeurs, par défaut et avec le Name en paramètre
        public Animal()
        {
            this.Name = "Unknown";
        }

        public Animal(string name)
        {
            this.Name = name;
        }





    }
}


