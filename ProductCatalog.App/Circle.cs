using System;

namespace ProductCatalog
{
    public class Circle
    {
        private double _radius = 0;
        public double Diameter 
        { 
            get{ return _radius * 2; }
            set { _radius = value / 2; }
        }

        public Circle(double diameter)
        {
            this.Diameter = diameter;
        }
    }
}