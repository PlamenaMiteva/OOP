using System;

public class Battery
    {
        private string batteryType;
        private double batteryLife;

        public Battery(string batteryType, double batteryLife)
        {
            this.BatteryType = batteryType;
            this.BatteryLife = batteryLife;
        }
        public string BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The Battery Type field cannot be empty.");
                }
                this.batteryType = value;
            }
        }
        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Battery life cannot be negative.");
                }
                this.batteryLife = value;
            }
        }
    }

