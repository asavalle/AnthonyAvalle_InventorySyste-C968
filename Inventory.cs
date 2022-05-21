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
  
        

        //  public static void addProduct(Product product) { }

        // public static bool removeProduct(int) { }

        // public static Product lookupProduct(int) { }

        // public static void updateProduct(int) { }
        
        /******************************************************************************************/

        public static void addPart(Part part) {
            //create new instance of bindinglist, and add passed in part type to list
            //Test if part is of type Inhouse or Outsourced and add <Part> variable and assign value of Machine or Company name
            AllParts.Add(part);
        }

        //  public static bool deletePart(int) { }

        //public static Part lookupPart(int){}

          public static void updatePart(int partID) {
           ModifyParts.ActiveForm. partID.ToString();
            
        }




        /*************************
        ***Hard coded test data***
        *************************/
        static Inventory()
        {
            

            //InHouse Parts Source
            AllParts.Add(new Inhouse { Name = "handle bar", Price = (decimal)10.00, InStock = 10, Min = 5, Max = 20, MachineID = 1000 });
            AllParts.Add(new Inhouse { Name = "front wheel", Price = (decimal)5.00, InStock = 10, Min = 10, Max = 40, MachineID = 1000 });
            AllParts.Add(new Inhouse { Name = "rear wheel", Price = (decimal)5.00, InStock = 10, Min = 10, Max = 40, MachineID = 1000 });
            AllParts.Add(new Inhouse { Name = "seat", Price = (decimal)5.00, InStock = 10, Min = 5, Max = 20, MachineID = 1000 });

            //Outsourced Parts Source
            AllParts.Add(new Outsourced { Name = "left pedal", Price = (decimal)10.00, InStock = 10, Min = 5, Max = 20, CompanyName = "Company1" });
            AllParts.Add(new Outsourced { Name = "right pedal", Price = (decimal)5.00, InStock = 10, Min = 10, Max = 40, CompanyName = "Company1" });
            AllParts.Add(new Outsourced { Name = "boy's frame", Price = (decimal)25.00, InStock = 10, Min = 10, Max = 40, CompanyName = "Company2" });
            AllParts.Add(new Outsourced { Name = "girls frame", Price = (decimal)25.00, InStock = 10, Min = 5, Max = 20, CompanyName = "Company3"});


        }

    }
}
