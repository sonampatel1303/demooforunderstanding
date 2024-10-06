using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thefirst.model
{
    public class Classw
    {
        public string Name {  get; set; }
        public Classw() { 
        
        }
        public Classw(string name)
        {
            Name = name;
            Console.WriteLine("FIrst");
        }
    }
}
