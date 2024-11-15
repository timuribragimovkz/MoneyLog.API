using MoneyLog.Domain.LogEntry.Models;
using MoneyLog.Infrastructure.MongoDb.Models;

namespace MoneyLog.Infrastructure.MongoDb.Databases;

public interface IMoneyLogEntryMongoDb : IBaseMongoDb<MoneyLogEntry, MoneyLogEntryDto>
{
}