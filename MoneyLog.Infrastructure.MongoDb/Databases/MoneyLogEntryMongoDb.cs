using Microsoft.Extensions.Options;
using MoneyLog.Domain.LogEntry.Models;
using MoneyLog.Infrastructure.MongoDb.Configs;
using MoneyLog.Infrastructure.MongoDb.Interfaces;
using MoneyLog.Infrastructure.MongoDb.Models;

namespace MoneyLog.Infrastructure.MongoDb.Databases;

public class MoneyLogEntryMongoDb : BaseMongoDb<MoneyLogEntry, MoneyLogEntryDto>, IMoneyLogEntryMongoDb, IMongoDb
{
    public MoneyLogEntryMongoDb(
        IOptions<MongoDbOptions> options) 
        : base(options, nameof(MoneyLogEntryMongoDb))
    {
    }
}