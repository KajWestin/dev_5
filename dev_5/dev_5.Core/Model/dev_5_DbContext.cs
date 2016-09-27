using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace dev_5.Core.Model
{
    class dev_5_DbContext : DbContext
    {
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
