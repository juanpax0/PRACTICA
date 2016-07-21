using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA.model
{
    class Product
    {
        public string id;
        public string name;
        public int quotationNum;

        public Product(string id, string name, int quotationNum)
        {
            this.id = id;
            this.name = name;
            this.quotationNum = quotationNum;
        }
    }
}
