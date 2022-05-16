using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace InventoryTrackingApp
{
    static class Inventory
    {
        public static BindingList<Product> Products { get; set; }

        public static BindingList<Part> bindList { get; set; }

        public static void addProduct() { }

        public static bool removeProduct(int) { }

        public static Product lookupProduct(int, Product) { }

        public static void updateProduct(int, Product) { }

        public static void addPart(Part) { }
        public static bool deletePart(Part) { }
        public static Part lookupPart(int) { }
        public static void updatePart(int, Part) { }
    }
}
