
using BoletoBusAppSol.Data.Entities.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BoletoBusAppSol.Data.Context
{
    public partial class BoletoContext
    {
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Asiento> Asientos { get; set; }
    }
}
