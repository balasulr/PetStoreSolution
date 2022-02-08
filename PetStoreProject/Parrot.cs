using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreProject {
    
    public class Parrot : IPetAnimal{
        // Properties
        public int Inventory { get; set; } = 0; // How many we have?
        public string Sound { get; set; }
        public decimal Price { get; set; }
        public int Longevity { get; set; }
        // Refrained from adding a Constructor & inialized in the Program.cs
    }
}
