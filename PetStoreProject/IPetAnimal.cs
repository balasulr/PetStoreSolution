using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreProject {

    public interface IPetAnimal {
        // What properties are common between Hedgehog, Parrot & Hamster
        public int Inventory { get; set; }
        public decimal Price { get; set; }
        public string Sound { get; set; }

    }
}
