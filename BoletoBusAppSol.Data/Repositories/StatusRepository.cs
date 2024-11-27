

using BoletoBusAppSol.Data.Base;
using BoletoBusAppSol.Data.Entities.Configuration;
using BoletoBusAppSol.Data.Interfaces;
using BoletoBusAppSol.Data.Models;
using System.Linq.Expressions;

namespace BoletoBusAppSol.Data.Repositories
{
    public sealed class StatusRepository : IBaseRepository<Status, short,StatusModel>
    {
        public Task<bool> Exists(Expression<Func<Status, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<StatusModel>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<List<StatusModel>>> GetAll(Expression<Func<Status, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<StatusModel>> GetEntityBy(short Id)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<StatusModel>> Remove(Status entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<StatusModel>> Save(Status entity)
        {
            throw new NotImplementedException();
        }

        public Task<OperationResult<StatusModel>> Update(Status entity)
        {
            throw new NotImplementedException();
        }
    }
}
