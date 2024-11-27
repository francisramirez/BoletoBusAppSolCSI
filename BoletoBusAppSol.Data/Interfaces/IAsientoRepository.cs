
using BoletoBusAppSol.Data.Base;
using BoletoBusAppSol.Data.Entities.Configuration;
using BoletoBusAppSol.Data.Models;

namespace BoletoBusAppSol.Data.Interfaces
{
    public interface IAsientoRepository : IBaseRepository<Asiento, int, AsientoBusModel>
    {
        public Task<OperationResult<List<AsientoBusModel>>> GetAsientosByBus(int idBus);
    }
}
