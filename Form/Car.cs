using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    public class Car
    {
        private int year;
        private string make;
        private string model;

        public Car(string make, string model, int year)
        {
            this.model = model;
            this.make = make;
            this.year = year;
        }
        public override string ToString() => $"Make: {make}\nModel: {model}\nYear: {year}";
    }
}
