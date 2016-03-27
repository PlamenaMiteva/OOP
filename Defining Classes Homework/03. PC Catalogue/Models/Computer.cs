namespace Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Computer
    {
        private string computerName;
        private List<Component> components;

        public Computer(string computerName)
        {
            this.ComputerName = computerName;
            this.components = new List<Component>();
        }

        public string ComputerName
        {
            get { return this.computerName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name field cannot be null or empty!");
                }
                this.computerName = value;
            }
        }


        public IEnumerable<Component> Components
        {
            get { return this.components; }
        }


        public decimal ComputerPrice
        {
            get { return this.Components.Sum(a => a.Price); }
        }



        public void AddComponent(Component component)
        {
            if (component == null)
            {
                throw new ArgumentNullException("Component cannot be null.");
            }
            if (this.components.Any(c => c.Name == component.Name))
            {
                throw new ArgumentException("Component already exists in this computer.");
            }
            this.components.Add(component);
        }



        public override string ToString()
        {
            string result = "Computer model: " + this.ComputerName;

            foreach (var item in this.components)
            {
                result += "\nComponent name:" + item.Name + "\nPrice:" + string.Format("{0:0.00}", item.Price) + " BGN.";
            }

            result += "\nTotal price: " + string.Format("{0:0.00}", this.ComputerPrice) + " BGN";
            return result;

        }
    }
}

