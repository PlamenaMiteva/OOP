namespace Empire.Models.Core.Buildings
{
    using System;
    using Empire.Models.Interfaces;

    public class ResourceProducedEventArgs : EventArgs
    {
        public IResource Resource { get; set; }
    }
}
