using System;

namespace lab2
{
    public class Point
    {
        private double _x;
        private double _y;
        
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        
        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }
        
        public Point()
        {
            _x = 0;
            _y = 0;
        }
        
        public override string ToString()
        {
            return "(" + _x + ";" + _y + ")";
        }
    }
}