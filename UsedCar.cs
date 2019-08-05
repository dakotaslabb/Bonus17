using Bonus17;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus17
{
    class UsedCar : Car
    {
        private string make;
        private string model;
        private int year;
        private double price;
        private double milage;

        public UsedCar(string make, string model, int year, double price, double milage) : 
            base(make,model,year,price)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.price = price;
            this.milage = milage;
        }
    public double Milage
    {
        get
        {
            return milage;
        }
    }
    public override string ToString()
    {
        return ($"{make}\t\t{model}\t\t{year}\t\t{price} (Used) {milage}");
    }
}
}
