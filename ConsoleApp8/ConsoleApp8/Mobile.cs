using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Mobile : IComparable<Mobile>
    {
        public int Year { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }

        public Mobile()
        {

        }

        public Mobile(int year, string model, int weight, int price)
        {
            this.Year = year;
            this.Model = model;
            this.Weight = weight;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"year: {Year}, model: {Model}, weight: {Weight}, price: {Price}";
        }

        
        public int CompareTo(Mobile other)
        {
            return this.Price - other.Price;
        }
    }
}
