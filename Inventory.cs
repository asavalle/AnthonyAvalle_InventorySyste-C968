using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using InventoryTrackingApp.Views;

namespace InventoryTrackingApp
{
    static class Inventory
    {
        
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();

        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        public static Part CurrentPart { get; set; }  
        public static int CurrentPartID { get; set; }
        public static Product CurrentProduct { get; set; }
        public static int CurrentProductID { get; set; }



        /***************PUBLIC METHODS****************/
        public static void addProduct(Product product) {
            Products.Add(product);
        }

        // public static bool removeProduct(int) { }

        public static Product lookupProduct(int prodID)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == prodID)
                {
                    return prod;
                }

            }
            return null;
        }

        // public static void updateProduct(int) { }

        /******************************************************************************************/

        public static void addPart(Part part) {
            AllParts.Add(part);
        }

        public static bool deletePart(Part part) {
            /*Removes the passed in part from the AllParts list.
            Then it itererates over the AllParts list and looks for any Part with a PartID
            greater than the PartID of the deleted part and decrements it's value. Effectively removing and 
            allowing for the reuse of that PartID */

            AllParts.Remove(part);
            foreach(Part p in AllParts)
            {
                if(p.PartID > part.PartID)
                {
                    p.PartID--;
                   
                };
            }
            return true;
        }

        public static Part lookupPart(int index) 
        {
            
            foreach(Part part in AllParts)
            {
                if(part.PartID == index)
                {
                    return part;
                }
               
            }
            return null;
        }
        public static void updatePart(int partID, Part partToUpdate) {
            /*Looks up the part in the list via the LookupPart method. Creates a new part and checks to see if the 
             current part being modified is equal to the passed in ID (which always will be) and then removes that current part and adds the new part to 
            the AllParts list.*/

            Part current = lookupPart(partID);
            Part newPart = partToUpdate;

            
                if(current.PartID == partID)
                {
                    AllParts.Remove(current);
                    AllParts.Add(newPart);
                }
            
            
        }




        /*************************
        ***Hard coded test data***
        *************************/
        static Inventory()
        {


            //    InHouse Parts Source
            AllParts.Add(new Inhouse { Name = "handle bar", Price = Convert.ToDecimal("10.20"), InStock = 10, Min = 5, Max = 20, MachineID = 1000 });
            AllParts.Add(new Inhouse { Name = "front wheel", Price = Convert.ToDecimal("5.20"), InStock = 10, Min = 10, Max = 40, MachineID = 1001 });
            AllParts.Add(new Inhouse { Name = "rear wheel", Price = Convert.ToDecimal("5.20"), InStock = 10, Min = 10, Max = 40, MachineID = 1002 });
            AllParts.Add(new Inhouse { Name = "seat", Price = Convert.ToDecimal("5.25"), InStock = 10, Min = 5, Max = 20, MachineID = 1000 });
            AllParts.Add(new Inhouse { Name = " Double Rear Wheel", Price = Convert.ToDecimal("10.99"), InStock = 20, Min = 10, Max = 20, MachineID = 1002 });

            //    Outsourced Parts Source
            AllParts.Add(new Outsourced { Name = "left pedal", Price = Convert.ToDecimal("10.20"), InStock = 10, Min = 5, Max = 20, CompanyName = "Company1" });
            AllParts.Add(new Outsourced { Name = "right pedal", Price = Convert.ToDecimal("5.45"), InStock = 10, Min = 10, Max = 40, CompanyName = "Company2" });
            AllParts.Add(new Outsourced { Name = "boy's frame", Price = Convert.ToDecimal("25.60"), InStock = 10, Min = 10, Max = 40, CompanyName = "Company3" });
            AllParts.Add(new Outsourced { Name = "girls frame", Price = Convert.ToDecimal("25.60"), InStock = 10, Min = 5, Max = 20, CompanyName = "Company4" });

            //Products Source
            Products.Add(new Product { Name = "Boy's Bicycle", Price = Convert.ToDecimal("150.00"), InStock = 10, Min = 5, Max = 20 });
            Products.Add(new Product { Name = "Girl's Bicycle", Price = Convert.ToDecimal("150.00"), InStock = 10, Min = 5, Max = 20 });
            Products.Add(new Product { Name = "Tri-wheeler", Price = Convert.ToDecimal("299.99"), InStock = 10, Min = 5, Max = 20 });

        }

    }
}
