using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// A way that was done to show how Interfaces work
namespace PetStoreProject {

    public class TestInterface : IPrint {
        // Whatever is being inherited has to be inherited in the Class
        public int Inventory { get; set; } // Have to include when inheriting IPrint
    }
}
