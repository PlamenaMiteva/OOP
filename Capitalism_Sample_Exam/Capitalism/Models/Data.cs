using System;
using System.Collections.Generic;
using Capitalism.Interfaces;

namespace Capitalism.Models
{
    public class Data : IData
    {
        public Data()
        {
            this.Companies = new List<Company>();
        }
        public ICollection<Company> Companies { get; protected set; }
    }
}
