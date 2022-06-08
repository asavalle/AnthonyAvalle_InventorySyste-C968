using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventoryTrackingApp
{
    class Product
    {


        //public properties
        public BindingList<Part> AssociatedParts { get; set; } 

        public int ProductID { get; set; }
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
        public void addAssociatedPart(Part part)
        {
            
            AssociatedParts.Add(part);
        }
        public bool removeAssociatedPart(int index) {
 
            AssociatedParts.Remove(lookupAssociatedPart(index));

            return true;
        }
        public Part lookupAssociatedPart(int index) 
        {
            return AssociatedParts[index];
        }




        
    }


    
}
