using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.Data.Entities
{
    class Product
    {
        private string id;
        private string name;
        private decimal price;

        public Product()
        {
        }

        public virtual string Id
        {
            get { return id; }
            set { id = value; }
        }

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
