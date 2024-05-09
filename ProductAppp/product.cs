using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppp
{
    public class Product : IProduct
    {
        private string _name;

        public Product(string name)
        {
            this._name = name;
        }

        public string getName()
        {
            return _name ;
        }
    }
}
