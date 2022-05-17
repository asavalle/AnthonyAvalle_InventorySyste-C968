using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventoryTrackingApp
{
    static class Inventory
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();

        public static BindingList<Part> AllParts { get; set; } = new BindingList<Part>();

        //  public static void addProduct(Product product) { }

        // public static bool removeProduct(int, Product) { }

        // public static Product lookupProduct(int, Product) { }

        // public static void updateProduct(int, Product) { }

        public static void addPart(Part part) {
            //create new instance of bindinglist, and add passed in part type to list
            AllParts.Add(part);
        }
        //  public static bool deletePart(int, Part) { }
        //  public static Part lookupPart(int, Part) { }
        //  public static void updatePart(int, Part) { }


        static Inventory()
        {
            //InHouse Parts Source
            AllParts.Add(new Inhouse { PartID = 1, Name = "handle bar", Price = (decimal)10.00, InStock = 10, Min = 5, Max = 20, MachineID = 1000 });
            AllParts.Add(new Inhouse { PartID = 2, Name = "front wheel", Price = (decimal)5.00, InStock = 10, Min = 10, Max = 40, MachineID = 1000 });
            AllParts.Add(new Inhouse { PartID = 3, Name = "rear wheel", Price = (decimal)5.00, InStock = 10, Min = 10, Max = 40, MachineID = 1000 });
            AllParts.Add(new Inhouse { PartID = 4, Name = "seat", Price = (decimal)5.00, InStock = 10, Min = 5, Max = 20, MachineID = 1000 });

            //Outsourced Parts Source
            AllParts.Add( new Outsourced{ PartID = 5, Name = "left pedal", Price = (decimal)10.00, InStock = 10, Min = 5, Max = 20,CompanyName= "Company1"});
            AllParts.Add(new Outsourced{ PartID = 6, Name = "right pedal", Price = (decimal)5.00, InStock = 10, Min = 10, Max = 40, CompanyName = "Company1" });
            AllParts.Add(new Outsourced{ PartID = 7, Name = "boy's frame", Price = (decimal)25.00, InStock = 10, Min = 10, Max = 40, CompanyName = "Company2" });
            AllParts.Add(new Outsourced{ PartID = 8, Name = "girls frame", Price = (decimal)25.00, InStock = 10, Min = 5, Max = 20, CompanyName = "Company3" });


        }
    }
}
