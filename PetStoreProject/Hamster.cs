﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreProject {

    public class Hamster : IPetAnimal {
        public int Inventory { get; set; } = 0; // How many we have?
        public string Sound { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
    }
}
