using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_List
{
  public class Product
    {
        public string Name { get; set; }
        public double Price{ get; set; }
        public override string ToString()
        {
            return $"Name is : {Name} || Price is: {Price}";
        }
    }
}
