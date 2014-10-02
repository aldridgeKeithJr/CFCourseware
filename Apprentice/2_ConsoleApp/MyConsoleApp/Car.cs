using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp
{
    public class Car
    {
        public string year { get; set; }
        public string make { get; set; }
        public string model { get; set; }

        public Car() { }

        public Car(string year, string make, string model) : this()
        {
            this.year = year;
            this.make = make;
            this.model = model;
        }
    }
}
