

using BoletoBusAppSol.Data.Base;
using BoletoBusAppSol.Data.Context;
using BoletoBusAppSol.Data.Entities.Configuration;
using BoletoBusAppSol.Data.Interfaces;
using BoletoBusAppSol.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace BoletoBusAppSol.Data.Repositories
{
    public sealed class AsientoRepository : IAsientoRepository
    {
        private readonly ILogger _logger;
        private readonly BoletoContext _context;
        public AsientoRepository(BoletoContext boletoContext, ILogger<AsientoRepository> logger)
        {
            _context = boletoContext;
            _logger = logger;
        }
        public Task<bool> Exists(Expression<Func<Asiento, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<AsientoBusModel>>> GetAll()
        {
            throw new NotImplementedException();
        }
        public async Task<OperationResult<List<AsientoBusModel>>> GetAsientosByBus(int idBus)
        {
            OperationResult<List<AsientoBusModel>> result = new OperationResult<List<AsientoBusModel>>();

            try
            {
                var query = await (from asiento in _context.Asientos
                                   join bus in _context.Buses on asiento.IdBus equals bus.Id
                                   where asiento.Estatus == true
                                   orderby asiento.FechaCreacion descending
                                   select new AsientoBusModel()
                                   {
                                       AsientoId = asiento.Id,
                                       BusId = bus.Id,
                                       Bus = bus.Nombre,
                                       FechaCreacion = asiento.FechaCreacion,
                                       NumeroAsiento = asiento.NumeroAsiento,
                                       NumeroPiso = asiento.NumeroPiso,
                                       FechaModificacion = asiento.FechaModificacion,
                                       UsuarioModificacion = asiento.UsuarioModificacion
                                   }).ToListAsync();


                result.Result = query;

            }
            catch (Exception ex)
            {

                result.Message = "Error obteniendo los asientos de un autobus.";
                result.Success = false;
                _logger.LogError($"{result.Message}", ex.ToString());
            }

            return result;
        }

        public Task<OperationResult<List<AsientoBusModel>>> GetAll(Expression<Func<Asiento, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<AsientoBusModel>> GetEntityBy(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<AsientoBusModel>> Remove(Asiento entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<AsientoBusModel>> Save(Asiento entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<AsientoBusModel>> Update(Asiento entity)
        {
            throw new NotImplementedException();
        }
    }
}
