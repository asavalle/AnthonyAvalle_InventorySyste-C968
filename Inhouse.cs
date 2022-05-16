using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTrackingApp
{
    class Inhouse : Part
    {
        public int MachineID { get; set; }
        public override int PartID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override decimal Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int InStock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Min { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Max { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



        //constructor
        public Inhouse(int id, string name,decimal price, int inStock, int min, int max)
        {

        }
    }


    
}
