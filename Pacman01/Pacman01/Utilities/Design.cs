using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pacman01.Elements;
using Pacman01.Utilities;
using Pacman01.Moves;
using Pacman01.GameProcess;

namespace Pacman01.Utilities
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
