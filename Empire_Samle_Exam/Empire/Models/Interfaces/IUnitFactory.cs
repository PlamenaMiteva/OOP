namespace Empire.Models.Interfaces
{
    public interface IUnitFactory
    {
        IUnit CreateUnit(string unitType);
    }
}
