using System;

namespace lab2
{
    // Расширенная Ломаная для заданий 4.9 и 5.7.
    public class PolylineExtended
    {
        private Point[] _points;

        public Point[] Points
        {
            get { return _points; }
            set { _points = value; }
        }
        
        public PolylineExtended()
        {
            _points = new Point[0];
        }
        
        public PolylineExtended(Point[] points)
        {
            _points = points;
        }
        
        public PolylineExtended AddPoint(Point p)
        {
            Point[] newPoints = new Point[_points.Length + 1];

            for (int i = 0; i < _points.Length; i++)
            {
                newPoints[i] = _points[i];
            }

            newPoints[_points.Length] = p;

            return new PolylineExtended(newPoints);
        }
        
        public PolylineExtended AddPoints(Point[] extra)
        {
            Point[] newPoints = new Point
                [_points.Length + extra.Length];

            for (int i = 0; i < _points.Length; i++)
            {
                newPoints[i] = _points[i];
            }

            for (int i = 0; i < extra.Length; i++)
            {
                newPoints[_points.Length + i] = extra[i];
            }

            return new PolylineExtended(newPoints);
        }
        
        public double Length()
        {
            if (_points.Length < 2)
            {
                return 0;
            }

            double total = 0;

            for (int i = 0; i < _points.Length - 1; i++)
            {
                double dx = _points[i + 1].X - _points[i].X;
                double dy = _points[i + 1].Y - _points[i].Y;
                total += Math.Sqrt(dx * dx + dy * dy);
            }

            return total;
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