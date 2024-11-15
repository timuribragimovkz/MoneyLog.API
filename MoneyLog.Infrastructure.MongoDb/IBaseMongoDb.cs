using MoneyLog.Domain.Common.Models;
using MoneyLog.Infrastructure.MongoDb.Interfaces;
using MoneyLog.Infrastructure.MongoDb.Models;

namespace MoneyLog.Infrastructure.MongoDb;

public interface IBaseMongoDb<TModel, TDto> 
    where TModel : BaseDomainModel 
    where TDto : BaseDto, IMapFromDto<TModel>, IMapToDto<TModel, TDto>, new()
{
    Task<TModel?> GetById(Guid id);
    Task<TModel> GetRequiredById(Guid id);
    Task<Guid> Insert(TModel model);
}