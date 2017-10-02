using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locatronics
{
    public class racks
    {
        public List<baskets> baskets = new List<Locatronics.baskets>();

        public void cell(int address, string component)
        {
            locations location = new locations();
            location.address = address;

            baskets b = new baskets();
            b.location = location;
            b.contents = component.ToUpper();

            baskets.Add(b);
        }
    }
}
