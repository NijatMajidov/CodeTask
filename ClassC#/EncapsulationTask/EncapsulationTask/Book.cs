using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationTask
{
    internal class Book : Product
    {
        public string Genre { get; set; }

        public Book(int no, double price, string name, int count, string genre):base(no,price, name,count)
        {
            Genre= genre;
        }
        
        public void ShowInfo()
        {   
            Console.WriteLine($"{this.No}   | {this.Name}    | {this.Price}    | {this.Count}   | {this.Genre}");
        }
    }
}
