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
            Inventory.AllParts.Add(new Inhouse ( "handle bar", Convert.ToDecimal("10.20"),  10,  5,  20, 1000 ));
            Inventory.AllParts.Add(new Inhouse("front wheel", Convert.ToDecimal("5.20"), 10, 10, 40, 1001));
            Inventory.AllParts.Add(new Inhouse("rear wheel", Convert.ToDecimal("5.20"), 10, 10, 40, 1002));
            Inventory.AllParts.Add(new Inhouse("seat", Convert.ToDecimal("5.25"), 10, 5, 20, 1000));
            Inventory.AllParts.Add(new Inhouse(" double rear wheel", Convert.ToDecimal("10.99"), 20, 10, 20, 1002));

            //    Outsourced Parts Source
            Inventory.AllParts.Add( new Outsourced ( "left pedal", Convert.ToDecimal("10.20"),10,5,  20,  "Company1" ));
            Inventory.AllParts.Add( new Outsourced("right pedal", Convert.ToDecimal("5.45"), 10, 10, 40, "Company2"));
            Inventory.AllParts.Add(new Outsourced("boy's frame", Convert.ToDecimal("25.60"), 10, 10, 20, "Company3"));
            Inventory.AllParts.Add( new Outsourced("girl's frame", Convert.ToDecimal("25.60"), 10, 5, 20, "Company4"));

            //AssociatedParts
            BindingList<Part> testParts = new BindingList<Part>();
            testParts.Add(new Inhouse("handle bar", Convert.ToDecimal("10.20"), 10, 5, 20, 1000));

            //Products Source
            Inventory.Products.Add(new Product ("boy's bicycle",  Convert.ToDecimal("150.00"),  10, 5, 20, testParts ));
            Inventory.Products.Add(new Product("girl's bicycle",  Convert.ToDecimal("150.00"),  10,  5,  20, testParts) );
            Inventory.Products.Add(new Product("tri-wheeler",  Convert.ToDecimal("299.99"),  10,  5,  20, testParts));

            

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
