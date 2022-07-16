using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project4form
{
    internal class Class1

    {
        static private List<Class1> items = new List<Class1>(); 
        public string Name { get; set; }
        public string id { get; set; }
        public string date { get; set; }
        public string phonenumber { get; set; }


        public void save()
        {
            MessageBox.Show("saved");
        }
  
                
     /*        public static List<Class1> GetAllProducts()
        {
            return Class1.GetAllProducts();
        }
     */
        



    }
}
