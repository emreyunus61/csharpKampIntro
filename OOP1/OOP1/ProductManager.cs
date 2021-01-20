using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager //Manager görünce anlaki o ürünle alakala operasyonlar var örneğin crud
    {

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "eklendi. ");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

    }
}
