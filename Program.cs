using System;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _1__Requêtes_sur_des_listes_d_objets___NET__
{
    class Program
    {
        static void Main(string[] args)
        {
            // Présentation de la classe Dog .
            // Récupérer tous les bergers Australiens .
            // Trier les chiens par leur nom .
            // Récupérer tous les chiens âgés de 5 ans et plus, dont la longueur du nom est supérieure à 5 .
            // Trier les chiens par leur poids .
            // Trier les chiens par leur âge (tri décroissant), puis leur poids (tri croissant) .
            // Requête avec 3 conditions et un tri . 

            List<Dog> Dogs = new List<Dog>
            {
                new Dog("Berger Australian", "Banzai", 1, 28),
                new Dog("Berger Australian", "Letto", 3, 30),
                new Dog("Berger Australian", "Princesse", 8, 32),
                new Dog("Berger Allemand", "Floyd", 10, 32),
                new Dog("Canish", "Igor", 13, 9),
                new Dog("Labrador", "Swing", 15, 25),
                new Dog("Teckel", "Wonki", 2, 5),
                new Dog("Terre Neuve", "Albator", 1, 50),
                new Dog("Carlin", "Pataud", 13, 10),
                new Dog("Boxer", "Frank", 6, 25),
                new Dog("Lévrier Afghan", "Précieuse", 9, 26),
                new Dog("Yorkshire", "Kakou", 3, 6)
            };

            // By Query Expression .

            var Berger_Australian = from brg 
                                    in Dogs 
                                    where brg.Race.Contains("Berger Australian")
                                    orderby brg.Name descending
                                    select brg;

            foreach (var brg in Berger_Australian)
                Console.WriteLine(brg.Name);

            Console.WriteLine("----------------------------------------------------------------------------");

            // Récupérer tous les chiens âgés de 5 ans et plus, dont la longueur du nom est supérieure à 5 .
            // Trier les chiens par leur poids .

            var query = from brg 
                        in Dogs 
                        where brg.Age >= 5 
                        where brg.Name.Length > 5 
                        orderby brg.Weight ascending
                        select brg;

            foreach (var item in query)
                Console.WriteLine(item.Name);

            Console.WriteLine("----------------------------------------------------------------------------");

            // Trier les chiens par leur âge (tri décroissant), puis leur poids (tri croissant) .

            var age_poid = from ap in Dogs
                           orderby ap.Age descending , ap.Weight ascending
                           select ap;

            foreach (var ap in age_poid)
                Console.WriteLine(ap.Name);
        }
    }
}
