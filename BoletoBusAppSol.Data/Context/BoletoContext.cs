


using Microsoft.EntityFrameworkCore;

namespace BoletoBusAppSol.Data.Context
{
    public partial class BoletoContext : DbContext
    {
        public BoletoContext(DbContextOptions<BoletoContext> options) : base(options) 
        {
            
        }

        


    }
}
