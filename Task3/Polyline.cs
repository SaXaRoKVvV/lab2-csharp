using System;

namespace lab2
{
    public class Polyline
    {
        private Point[] _points;

        public Point[] Points
        {
            get { return _points; }
            set { _points = value; }
        }
        
        public Polyline(Point[] points)
        {
            _points = points;
        }
        
        public Polyline()
        {
            _points = new Point[0];
        }
        
        public override string ToString()
        {
            string result = "Линия [";

            for (int i = 0; i < _points.Length; i++)
            {
                result += _points[i].ToString();
                if (i < _points.Length - 1)
                {
                    result += ",";
                }
            }

            result += "]";
            return result;
        }
    }
}