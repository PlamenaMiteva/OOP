using System;


public class Laptop
{
    private string model;
    private string manifacturer;
    private string processor;
    private string ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private double price;
    private Battery battery;

    public Laptop(string model, string manifacturer, string processor, string ram, string graphicsCard, 
        string hdd, string screen,Battery battery, double price)
    {
        this.Model = model;
        this.Manifacturer = manifacturer;
        this.Processor = processor;
        this.RAM = ram;
        this.GraphicsCard = graphicsCard;
        this.HDD = hdd;
        this.Screen = screen;
        this.Battery = battery;
        this.Price = price;
    }
    public Laptop(string model, double price)
    {
        this.Model = model;
        this.Price = price;
    }


    public string Model
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Model cannot be empty!");
            }
            this.model = value;
        }
    }

    public string Manifacturer
    {
        get { return this.manifacturer; }
        set
        {
            this.manifacturer = value;
        }
    }

    public string Processor
    {
        get { return this.processor; }
        set
        {
            this.processor = value;
        }
    }

    public string RAM
    {
        get { return this.ram; }
        set
        {
            this.ram = value;
        }
    }

    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            this.graphicsCard = value;
        }
    }

    public string Screen
    {
        get { return this.screen; }
        set
        {
            this.screen = value;
        }
    }

    public string HDD
    {
        get { return this.hdd; }
        set
        {
            this.hdd = value;
        }
    }

    public double Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be negative.");
            }
            this.price = value;
        }
    }

    public Battery Battery { get; set; }

    public override string ToString()
    {

        if (this.Manifacturer != null)
        {
            return "Model: " + this.Model + "\nManifacturer:" + this.Manifacturer + "\nProcessor:" + 
                this.Processor + "\nRAM:" + this.RAM + "\nGraphics Card:" + this.GraphicsCard + 
                "\nHDD:" + this.HDD + "GB SSD" + "\nBattery:" + this.Battery.BatteryType + "\nBattery Life:" + 
                this.Battery.BatteryLife + "hours" + "\nPrice: " + string.Format("{0:0.00}", this.Price) + "lv.";
        }
        else
        {
            return "Model: " + this.Model + "\nPrice: " + string.Format("{0:0.00}", this.Price) + "lv.";
        }
    }
}

