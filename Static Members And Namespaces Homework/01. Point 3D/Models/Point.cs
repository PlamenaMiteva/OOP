namespace Models
{
    using System;

    public class Point
    {
        private static readonly Point startingPoint = new Point(0, 0, 0);

        public Point(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point StartingPoint
        {
            get { return startingPoint; }
        }

        public override string ToString()
        {
            string result = String.Format("x: {0}, y: {1}, z: {2}",
                this.X.ToString(),
                this.Y.ToString(),
                this.Z.ToString());
            return result;
        }
    }
}

