﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTrackingApp
{
    class Inhouse : Part
    {

        public override int PartID { get; set; }
        public override string Name { get; set; }
        public override decimal Price { get; set; }
        public override int InStock { get; set; }
        public override int Min { get; set; }
        public override int Max { get; set; }
        public int MachineID { get; set; } = 100;




        //On constructor call, counts number of elements in the AllParts list and assigns to PartID


        public Inhouse()
        {
           PartID += Inventory.AllParts.Count;
        }

    }



}
