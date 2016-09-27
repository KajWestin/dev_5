using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace dev_5.Core.Model
{
    public class Toyota : Car
    {
        public new void IncreaseSpeedWith(int amount)
        {
            Speed += amount;

            if (Speed > 190) { Speed = 190; }
        }
    }
}
