using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
{
    internal class Product
    {
        private double _price;
        public double Price { get { return _price; }
            set { if(value>0) _price = value; }
        }

        private int _count;
        public int Count { get { return _count; }
            set { if(value>0)  _count = value; }
        }

        public int No { get; set; }
        public string Name { get; set;}

        public Product(int no, double price, string name)
        {
            No = no;
            Name = name;
            _price = price;
            
        }
        public Product(int no, double price, string name, int count):this(no,price,name)
        {
            _count = count;
            
        }
    }
}
