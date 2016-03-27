namespace Empire.Models.Core.Buildings
{
    using System;
    using Empire.Models.Interfaces;

    public class UnitProducedEventArgs : EventArgs
    {
        public IUnit Unit { get; set; }
    }
}
