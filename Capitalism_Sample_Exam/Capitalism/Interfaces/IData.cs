using Capitalism.Models;

namespace Capitalism.Interfaces
{
    using System.Collections.Generic;

    public interface IData
    {
        ICollection<Company> Companies { get; }
    }
}
