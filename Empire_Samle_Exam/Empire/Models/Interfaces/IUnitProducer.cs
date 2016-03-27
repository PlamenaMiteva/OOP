namespace Empire.Models.Interfaces
{
    public interface IUnitProducer
    {
        IUnit ProduceUnit();

        bool CanProduceUnit { get; }
    }
}
