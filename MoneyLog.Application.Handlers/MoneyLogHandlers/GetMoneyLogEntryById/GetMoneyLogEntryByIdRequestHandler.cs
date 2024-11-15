using MoneyLog.Application.Handlers.Interfaces;
using MoneyLog.Infrastructure.MongoDb.Databases;

namespace MoneyLog.Application.Handlers.MoneyLogHandlers.GetMoneyLogEntryById;

public class GetMoneyLogEntryByIdRequestHandler : IHandler<GetMoneyLogEntryByIdRequest, GetMoneyLogEntryByIdResponse>
{
    private readonly IMoneyLogEntryMongoDb _moneyLogEntryMongoDb;

    public GetMoneyLogEntryByIdRequestHandler(IMoneyLogEntryMongoDb moneyLogEntryMongoDb)
    {
        _moneyLogEntryMongoDb = moneyLogEntryMongoDb;
    }

    public async Task<GetMoneyLogEntryByIdResponse> Handle(GetMoneyLogEntryByIdRequest request)
    {
        var foundMoneyLogEntry = await _moneyLogEntryMongoDb.GetRequiredById(request.Id);

        return GetMoneyLogEntryByIdResponse.FromMoneyLogEntry(foundMoneyLogEntry);
    }
}