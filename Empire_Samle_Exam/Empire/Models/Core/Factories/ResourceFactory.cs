namespace Empire.Models.Core.Factories
{
    using Empire.Models.Enums;
    using Empire.Models.Interfaces;

    public class ResourceFactory : IResourceFactory
    {
        public IResource CreateResource(ResourceType resourceType, int quantity)
        {
            return new Resource(resourceType, quantity);
        }
    }
}
