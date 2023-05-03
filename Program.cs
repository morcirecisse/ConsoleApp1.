using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* // Etape 1
             int salaireAnnuel = 30000;
             double salaireMensuel = salaireAnnuel / 12.0;
             Console.WriteLine("Le salaire net mensuel pour un salaire annuel de 30 000 € est : " + salaireMensuel + " €");

             // Etape 2
             Console.WriteLine("Entrez le salaire annuel : ");
             int salaire = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Entrez le taux d'imposition en pourcentage : ");
             int taux = Convert.ToInt32(Console.ReadLine());
             double salaireNet = salaire * (100 - taux) / 100.0;
             double salaireNetMensuel = salaireNet / 12.0;
             Console.WriteLine("Le salaire net mensuel pour un salaire annuel de " + salaire + " € avec un taux d'imposition de " + taux + "% est : " + salaireNetMensuel + " €");

             // Etape 3
             Console.WriteLine("Entrez le salaire annuel : ");
             string inputSalaire = Console.ReadLine();
             Console.WriteLine("Entrez le taux d'imposition en pourcentage : ");
             string inputTaux = Console.ReadLine();

             int salaire2, taux2;
             bool isSalaireInt = int.TryParse(inputSalaire, out salaire2);
             bool isTauxInt = int.TryParse(inputTaux, out taux2);

             if (isSalaireInt && isTauxInt)
             {
                 double salaireNet2 = salaire2 * (100 - taux2) / 100.0;
                 double salaireNetMensuel2 = salaireNet2 / 12.0;

                 if (salaire2 > 50000)
                 {
                     Console.WriteLine("Votre salaire est supérieur à 50 000 €. Pour réduire vos impôts, nous vous conseillons de faire des dons à des associations reconnues d'intérêt public.");
                 }
                 else if (salaireNetMensuel2 < 1500)
                 {
                     Console.WriteLine("Votre salaire mensuel net est inférieur à 1 500 €. Cela peut être normal pour un alternant.");
                 }
                 else if (salaire2 >= 30000 && salaire2 <= 40000)
                 {
                     Console.WriteLine("Votre salaire annuel se situe entre 30 000 € et 40 000 €. Nous vous conseillons de venir à CESI pour un bac+5 en développement informatique !");
                 }

                 Console.WriteLine("Le salaire net mensuel pour un salaire annuel de " + salaire2 + " € avec un taux d'imposition de " + taux2 + "% est : " + salaireNetMensuel2 + " €");

             }
             else
             {
                 Console.WriteLine("Dommage, le salaire et le taux d'imposition doivent être des nombres entiers.");
             }*/



             //Boucle

                  // Etape 1 : Créer un tableau avec les mois de l’année
                  string[] mois = { "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", "Août", "Septembre", "Octobre", "Novembre", "Décembre" };

                  // Etape 2 : Afficher pour chaque mois de l’année, le mois et le salaire de l’utilisateur
                  double salaireAnnuel = 50000;
                  double salaireMensuel = salaireAnnuel / 12;

                  for (int i = 0; i < mois.Length; i++)
                  {
                      if (mois[i] != "Août")
                      {
                          Console.WriteLine(mois[i] + " : " + salaireMensuel + "€");
                      }
                  }

                  // Etape 3 : Ajouter une prime de fin d’année pour Décembre a hauteur de 10% du salaire annuel
                  double primeDecembre = salaireAnnuel * 0.1;
                  Console.WriteLine("Prime de Décembre : " + primeDecembre + "€");



            /*

        try
        {
            Console.Write("Entrez le montant en pourcentage de la prime de Noël : ");
            int pourcentage = int.Parse(Console.ReadLine());

            // Vérification que le pourcentage est différent de zéro
            if (pourcentage == 0)
            {
                throw new Exception("Le pourcentage ne peut pas être égal à zéro.");
            }

            Console.WriteLine("Le montant de la prime de Noël est de {0} euros.", 500 * pourcentage / 100);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Erreur : le montant entré n'est pas un nombre entier.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Erreur : {0}", e.Message);
        }

        Console.ReadLine();

        */



            /*

                Console.WriteLine("Que voulez-vous faire ?");
                Console.WriteLine("1. Afficher vos informations personnelles");
                Console.WriteLine("2. Calculer les intérêts composés");

                string choix = Console.ReadLine();
                if (choix == "1")
                {


                    User user1 = new User(1, "John", "Doe", 30, 50000, 0.2M);

                    Console.WriteLine($"Id: {user1.Id}");
                    Console.WriteLine($"First Name: {user1.FirstName}");
                    Console.WriteLine($"Last Name: {user1.LastName}");
                    Console.WriteLine($"Age: {user1.Age}");
                    Console.WriteLine($"Salary: {user1.Salary}");
                    Console.WriteLine($"Tax: {user1.Tax}");

                }
                else if (choix == "2")
                {
                    // Calculer les intérêts composés
                    Console.Write("Entrez votre capital investi : ");
                    decimal capital = decimal.Parse(Console.ReadLine());

                    Console.Write("Sur combien d'années voulez-vous investir ? ");
                    int annees = int.Parse(Console.ReadLine());

                    Console.Write("Quel est le taux d'intérêt annuel en pourcentage ? ");
                    decimal taux = decimal.Parse(Console.ReadLine()) / 100;

                    decimal capitalFinal = capital * (decimal)Math.Pow((double)(1 + taux), annees);

                    Console.WriteLine("Année\tCapital");
                    for (int annee = 1; annee <= annees; annee++)
                    {
                        decimal capitalAnnee = capital * (decimal)Math.Pow((double)(1 + taux), annee);
                        Console.WriteLine($"{annee}\t{capitalAnnee:C2}");
                    }

                    Console.WriteLine($"Capital final après {annees} ans : {capitalFinal:C2}");
                }
                else
                {
                    Console.WriteLine("Choix invalide");
                }
                    
                */






          /*  List<Dog> dogs = new List<Dog>
            {
                new Dog("Snow"),
                new Dog("Tic"),
                new Dog("Tac"),
                new Dog("Jessie"),
                new Dog("James"),
            };

            Dog dog = new Dog("Loup", "Epic", 10, 99);
            Dragon enderDragon = new Dragon("Ender Dragon", "Legendary", 99, 10);
            Griffin griffin = new Griffin("GriffonDort", "Rare", 5, 10);
            Dragon ptera = new Dragon("Ptera", "Commun", 1, 25);
            Dog wolf = new Dog("Wolf", "Commun", 2, 685);
            Dog ben = new Dog("Ben", "Commun", 20, 65);

            List<Animal> liste = new List<Animal> { dog, enderDragon, griffin, ptera, wolf, ben };
            var result = liste.OrderBy(a => a.Type).ThenByDescending(a => a.Age);

            Console.WriteLine("List of all animals from the rarest to the least rare with their age:");
            foreach (var animal in result)
            {
                Console.WriteLine($"Type: {animal.Type}, Name: {animal.Name}, Age: {animal.Age}");
            }

            Console.ReadLine()

            */



        }
    }
}





