using Microsoft.Extensions.Options;
using MoneyLog.Domain.Common.Models;
using MoneyLog.Infrastructure.MongoDb.Configs;
using MoneyLog.Infrastructure.MongoDb.Exceptions;
using MoneyLog.Infrastructure.MongoDb.Interfaces;
using MoneyLog.Infrastructure.MongoDb.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;

namespace MoneyLog.Infrastructure.MongoDb;

public class BaseMongoDb<TModel, TDto> : IBaseMongoDb<TModel, TDto>
    where TModel : BaseDomainModel
    where TDto : BaseDto, IMapFromDto<TModel>, IMapToDto<TModel, TDto>, new()
{
    protected readonly IMongoCollection<TDto> Collection;

    protected BaseMongoDb(IOptions<MongoDbOptions> options, string collectionName)
    {
        var optionsValue = options.Value;
        var client = new MongoClient(optionsValue.ConnectionString);
        var database = client.GetDatabase(optionsValue.DataBaseName);
        Collection = database.GetCollection<TDto>(collectionName);
        
        // BsonSerializer.RegisterSerializer(new GuidSerializer(BsonType.String));
    }

    public async Task<TModel?> GetById(Guid id)
    {
        var foundDto = await Collection.FindAsync(x => x.Id == id);

        var model = foundDto?.First().FromDto();

        return model;
    }

    public async Task<TModel> GetRequiredById(Guid id)
    {
        var foundModel = await GetById(id);
        if (foundModel == null)
        {
            throw new BaseMongoDbException($"Item not found by id: {id.ToString()}.");
        }

        return foundModel;
    }

    public async Task<Guid> Insert(TModel model)
    {
        var dto = new TDto().ToDto(model);

        await Collection.InsertOneAsync(dto);

        return dto.Id;
    }
}