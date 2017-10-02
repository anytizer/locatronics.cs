using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locatronics
{
    public class rack
    {
        public List<basket> baskets = new List<Locatronics.basket>();

        public void cell(int address, string component)
        {
            location location = new location();
            location.address = address;

            basket b = new basket();
            b.location = location;
            b.contents = component.ToUpper();

            baskets.Add(b);
        }
    }
}
