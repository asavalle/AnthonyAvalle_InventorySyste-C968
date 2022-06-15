using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTrackingApp
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            /*************************
            ***Hard coded test data***
            *************************/  
            
            //    InHouse Parts Source
            Inventory.AllParts.Add(new Inhouse ( "handle bar", 10,Convert.ToDecimal("10.20"), 20, 2, 1000 ));
            Inventory.AllParts.Add(new Inhouse("front wheel",10, Convert.ToDecimal("5.20"),  10, 4, 1001));
            Inventory.AllParts.Add(new Inhouse("rear wheel", 10,Convert.ToDecimal("5.20"),  10, 4, 1002));
            Inventory.AllParts.Add(new Inhouse("seat", 10,Convert.ToDecimal("5.25"),  50, 2, 1000));
            Inventory.AllParts.Add(new Inhouse(" double rear wheel",20, Convert.ToDecimal("10.99"),  50, 20, 1002));

            //    Outsourced Parts Source
            Inventory.AllParts.Add( new Outsourced ( "left pedal",10, Convert.ToDecimal("10.20"),50,  20,  "Company1" ));
            Inventory.AllParts.Add( new Outsourced("right pedal", 10, Convert.ToDecimal("5.45"), 100, 40, "Company2"));
            Inventory.AllParts.Add(new Outsourced("boy's frame", 10, Convert.ToDecimal("25.60"), 100, 20, "Company3"));
            Inventory.AllParts.Add( new Outsourced("girl's frame", 10,Convert.ToDecimal("25.60"),  50, 20, "Company4"));

            //AssociatedParts
            BindingList<Part> testParts = new BindingList<Part>();
            testParts.Add(new Inhouse("handle bar",10,  Convert.ToDecimal("10.20"), 5, 20, 1000));

            //Products Source
            Inventory.Products.Add(new Product ("boy's bicycle", 10, Convert.ToDecimal("150.00"),   50, 20, testParts ));
            Inventory.Products.Add(new Product("girl's bicycle", 10, Convert.ToDecimal("150.00"),    50,  20, testParts) );
            Inventory.Products.Add(new Product("tri-wheeler", 10,  Convert.ToDecimal("299.99"),   50,  20, testParts));

            

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
