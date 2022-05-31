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

        /***************************  PARTS  **************************************************/

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




        
       
    }
}
