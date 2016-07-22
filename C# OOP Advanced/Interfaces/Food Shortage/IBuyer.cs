using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Shortage
{
    interface IBuyer
    {
        int Food { get; set; }
        void BuyFood();
    }
}
