using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Data.Entities;

namespace WebShop.Data.Repositories
{
    interface IProductRepository : IDisposable
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int studentId);
        void InsertProduct(Product student);
        void DeleteProduct(int studentID);
        void UpdateProduct(Product student);
        void Save();
    }
}
