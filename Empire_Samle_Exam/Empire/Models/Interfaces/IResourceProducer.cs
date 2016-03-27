namespace Empire.Models.Interfaces
{
    public interface IResourceProducer
    {
        IResource ProduceResource();

        bool CanProduceResource { get; }
    }
}
