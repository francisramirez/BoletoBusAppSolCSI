
using BoletoBusAppSol.Data.Base;
using System.Linq.Expressions;

namespace BoletoBusAppSol.Data.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <typeparam name="TType"></typeparam>
    /// <typeparam name="TModel"></typeparam>
    public interface IBaseRepository<TEntity,TType,TModel> where TEntity : class
    {
        Task<OperationResult<TModel>> Save(TEntity entity);
        Task<OperationResult<TModel>> Update(TEntity entity);
        Task<OperationResult<TModel>> Remove(TEntity entity);
        Task<OperationResult<List<TModel>>> GetAll();
        Task<OperationResult<List<TModel>>> GetAll(Expression<Func<TEntity, bool>> filter);
        Task<OperationResult<TModel>> GetEntityBy(TType Id);
        Task<bool> Exists(Expression<Func<TEntity, bool>> filter);
        
    }
}
