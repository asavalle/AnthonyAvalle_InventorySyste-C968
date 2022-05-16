using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventoryTrackingApp
{
    class Product
    {


        //public properties
        private BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        //public methods
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool removeAssociatedPart(int index) {
            if (index > AssociatedParts.Count) return false;

            AssociatedParts.Remove(lookupAssociatedPart(index));

            return true;
        }
        public Part lookupAssociatedPart(int index) 
        {
            return AssociatedParts[index];
        }


        static Product()
        {

        }
    }


    
}
