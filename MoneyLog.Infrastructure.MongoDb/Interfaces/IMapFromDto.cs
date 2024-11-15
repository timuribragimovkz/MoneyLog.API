using MoneyLog.Domain.Common.Models;

namespace MoneyLog.Infrastructure.MongoDb.Interfaces;

public interface IMapFromDto<TModel>
where TModel : BaseDomainModel
{
    TModel FromDto();
}