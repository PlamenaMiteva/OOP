namespace Empire.Models.Interfaces
{
    using Empire.Models.Enums;

    public interface IResourceFactory
    {
        IResource CreateResource(ResourceType resourceType, int quantity);
    }
}
