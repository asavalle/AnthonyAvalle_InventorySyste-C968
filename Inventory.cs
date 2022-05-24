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


        //  public static void addProduct(Product product) { }

        // public static bool removeProduct(int) { }

        // public static Product lookupProduct(int) { }

        // public static void updateProduct(int) { }
        
        /******************************************************************************************/

        public static void addPart(Part part) {
            AllParts.Add(part);
        }

        //  public static bool deletePart(int) { }

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
            AllParts.Add(new Inhouse { Name = "handle bar", Price = (decimal)10.00, InStock = 10, Min = 5, Max = 20, MachineID = 1000 });
            AllParts.Add(new Inhouse { Name = "front wheel", Price = (decimal)5.00, InStock = 10, Min = 10, Max = 40, MachineID = 1001 });
            AllParts.Add(new Inhouse { Name = "rear wheel", Price = (decimal)5.00, InStock = 10, Min = 10, Max = 40, MachineID = 1002 });
            AllParts.Add(new Inhouse { Name = "seat", Price = (decimal)5.00, InStock = 10, Min = 5, Max = 20, MachineID = 1000 });

            //    Outsourced Parts Source
            AllParts.Add(new Outsourced { Name = "left pedal", Price = (decimal)10.00, InStock = 10, Min = 5, Max = 20, CompanyName = "Company1" });
            AllParts.Add(new Outsourced { Name = "right pedal", Price = (decimal)5.00, InStock = 10, Min = 10, Max = 40, CompanyName = "Company2" });
            AllParts.Add(new Outsourced { Name = "boy's frame", Price = (decimal)25.00, InStock = 10, Min = 10, Max = 40, CompanyName = "Company3" });
            AllParts.Add(new Outsourced { Name = "girls frame", Price = (decimal)25.00, InStock = 10, Min = 5, Max = 20, CompanyName = "Company4" });


        }

    }
}
