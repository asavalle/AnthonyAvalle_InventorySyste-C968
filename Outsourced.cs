using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryTrackingApp
{
    class Outsourced : Part
    {
        public override int PartID { get; set; }
        public override string Name { get; set; }
        public override decimal Price { get; set; }
        public override int InStock { get; set; }
        public override int Min { get; set; }
        public override int Max { get; set; }
        public string CompanyName { get; set; }

        //On constructor call, counts number of elements in the AllParts list and assigns to PartID
        public Outsourced( string name, decimal price, int inStock, int min, int max, string companyName)
        {
            PartID += Inventory.AllParts.Count;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            CompanyName = companyName;

        }
    }
}
