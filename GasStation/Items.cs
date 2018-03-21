using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasStation
{
    public class Items
    {
        public Guid Id { get; private set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public TypePeace Type { get; set; }

        public Items()
        {
            Id = new Guid();
        }
    }
}
