using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA.model
{
    class Person
    {
        public string id;
        public string password;

        public Person(string id, string password)
        {
            this.id = id;
            this.password = password;
        }
    }
}
