using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace dev_5.Core.Model
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        private int _speed;
        
        public int Speed{ get { return _speed; } set { _speed = value; } }

        public void IncreaseSpeedWith(int amount)
        {
            Speed += amount;

            if (Speed > 200) { Speed = 200; }
        }

        public void DecreaseSpeedWith(int amount)
        {
            Speed -= amount;

            if (Speed < 0) { Speed = 0; }
        }
    }
}
