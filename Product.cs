using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventoryTrackingApp
{
    class Product
    {


        //public properties
        public static BindingList<Part> AssociatedParts { get; set; }

        public int ProductID { get; set; } = 0;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }



        public Product( string name, decimal price, int inStock, int min, int max, BindingList<Part> list)
        {
            ProductID += Inventory.Products.Count;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
            AssociatedParts = list;
        }




        //public methods
        public static void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public static bool removeAssociatedPart(int index) {
            /*if (index > AssociatedParts.Count) return false*/;

            AssociatedParts.Remove(lookupAssociatedPart(index));

            return true;
        }
        public static Part lookupAssociatedPart(int index) 
        {
            return AssociatedParts[index];
        }




        
    }


    
}
