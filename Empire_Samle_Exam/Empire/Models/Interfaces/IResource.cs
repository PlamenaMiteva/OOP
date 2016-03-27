namespace Empire.Models.Interfaces
{
    using Empire.Models.Enums;

    public interface IResource
    {
        ResourceType ResourceType { get; }

        int Quantity { get; }
    }
}
