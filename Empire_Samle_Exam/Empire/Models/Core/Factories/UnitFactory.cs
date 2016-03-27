namespace Empire.Models.Core.Factories
{
    using System;
    using Empire.Models.Core.Units;
    using Empire.Models.Interfaces;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            switch (unitType)
            {
                case "Archer":
                    return new Archer();
                case "Swordsman":
                    return new Swordsman();
                default:
                    throw new ArgumentException("Unknown unit type");
            }
        }
    }
}
