using MoneyLog.Domain.Common.Models;
using MoneyLog.Infrastructure.MongoDb.Models;

namespace MoneyLog.Infrastructure.MongoDb.Interfaces;

public interface IMapToDto<in TModel,out TDto>
where TDto : BaseDto
where TModel : BaseDomainModel
{
    TDto ToDto(TModel model);
}