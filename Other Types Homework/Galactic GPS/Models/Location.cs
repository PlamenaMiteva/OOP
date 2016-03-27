using System.Runtime.CompilerServices;

namespace Galactic_GPS.Models
{
    using System;

    public struct Location
    {
        private double latitude;
        private double longitude;
        private Planet planet;

        public Location(double latitude, double longitude, Planet planet)
            : this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        public double Latitude
        {
            get { return this.latitude; }
            set
            {
                if (value > 90 || value < -90)
                {
                    throw new ArgumentOutOfRangeException("Latitude is in the range [-90...90].");
                }
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get { return this.longitude; }
            set
            {
                if (value > 180 || value <-180)
                {
                    throw new ArgumentOutOfRangeException("Longitude is in the range [-180...180].");
                }
                this.longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public override string ToString()
        {
            return string.Format("Latitude: {0}, Longitude: {1}, Location: {2}",
                this.Latitude, this.Longitude, this.Planet);
        }
    }
}
