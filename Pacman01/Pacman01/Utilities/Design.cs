using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman.Utilities
{
    public class Design
    {
        public Design(char appearace, int price)
        {
            this.appearance = appearace;
            this.price = price;
        }
        public char appearance
        {
            get; set;
        }
        public int price
        {
            get; set;
        }
    }
}
