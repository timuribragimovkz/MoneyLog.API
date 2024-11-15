using MoneyLog.Application.Handlers.Interfaces;
using MoneyLog.Infrastructure.MongoDb.Databases;

namespace MoneyLog.Application.Handlers.MoneyLogHandlers.AddMoneyLogEntry;

public class AddMoneyLogEntryRequestHandler : IHandler<AddMoneyLogEntryRequest, AddMoneyLogEntryResponse>
{
    private readonly IMoneyLogEntryMongoDb _moneyLogEntryMongoDb;

    public AddMoneyLogEntryRequestHandler(IMoneyLogEntryMongoDb moneyLogEntryMongoDb)
    {
        _moneyLogEntryMongoDb = moneyLogEntryMongoDb;
    }

    public async Task<AddMoneyLogEntryResponse> Handle(AddMoneyLogEntryRequest request)
    {
        var moneyLogEntry = request.ToMoneyLogEntry();

        await _moneyLogEntryMongoDb.Insert(moneyLogEntry);

        return new AddMoneyLogEntryResponse(moneyLogEntry.Id);
    }
}