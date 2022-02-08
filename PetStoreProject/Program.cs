using System;
using System.Collections.Generic;

namespace PetStoreProject {
    
    class Program {
        
        static void Main(string[] args) {

            Parrot parrot = new Parrot() { // Newest way to inialize properties & can have on single line
                Inventory = 17,
                Sound = "Squak",
                Price = 3000, // Price per Parrot
                Longevity = 60
            };
            Hedgehog hedgehog = new Hedgehog() {
                Inventory = 3,
                Sound = "Sqeak",
                Price = 200, // Price per Hedgehog
                CuteLevel = "Ultimate"
            };
            Hamster hamster = new Hamster() {
                Inventory = 200,
                Sound = "Squeak'em",
                Price = 10, // Price per Hamster
                Color = "Light Brown"
            };
            // Collection called IPetAnimals
            List<IPetAnimal> animals = new List<IPetAnimal>();
            // Adding animals to the Collection
            animals.Add(parrot);
            animals.Add(hedgehog);
            animals.Add(hamster);

            decimal total = 0;
            foreach(IPetAnimal a in animals) {
                decimal value = a.Price * a.Inventory;
                total += value;
                Console.WriteLine($"All {a.GetType().Name}s will net {value:c}.\n");
            }
            Console.WriteLine($"The total value is {total:c}.");
        }
    }
}
