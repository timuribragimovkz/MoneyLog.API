using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MoneyLog.Infrastructure.MongoDb.Models;

public abstract class BaseDto
{
    [BsonId]
    [BsonRepresentation(BsonType.String)]
    public Guid Id { get; init; }
    
    public BaseDto(Guid? id = default)
    {
        Id = id ?? Guid.NewGuid();
    }
}