using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTrackingApp
{
    abstract class Part
    {


        //public properties
        public virtual int PartID { get; set; } = 0;
        public abstract string Name { get; set; }
        public abstract decimal Price { get; set; }

        public abstract int InStock { get; set; }
        public abstract int Min { get; set; }
        public abstract int Max { get; set; }


        




    }
}
