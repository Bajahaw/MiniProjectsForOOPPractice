using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppp
{
    public class Repository<T> where T : Product
    {
        private  List<T> _products = new List<T>();

        public  void AddProduct(T product) 
        {
            _products.Add(product);
        }
        public  void RemoveProduct(T product) 
        {
            _products.Remove(product);
        }
        public  List<T> get() 
        {
         return _products;
        }

        public IEnumerator<T> GetEnumerator() 
        {
          return _products.GetEnumerator();
        }
    }
}
