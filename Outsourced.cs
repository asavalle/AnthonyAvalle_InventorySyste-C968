using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTrackingApp
{
    class Outsourced : Part
    {
        public override int PartID { get; set; }
        public override string Name { get; set; }
        public override int InStock { get; set; }
 public override decimal Price { get; set; }
        public override int Max { get; set; }
        public override int Min { get; set; }
        public string CompanyName { get; set; }

        //On constructor call, counts number of elements in the AllParts list and assigns to PartID
        public Outsourced( string name, int inStock,decimal price, int max, int min, string companyName)
        {
            PartID += Inventory.AllParts.Count;
            Name = name;
            InStock = inStock;
            Price = price;
            Max = max;
            Min = min;
            CompanyName = companyName;

        }
    }
}
