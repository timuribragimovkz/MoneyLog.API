using MoneyLog.Domain.LogEntry.Models;

namespace MoneyLog.Application.Handlers.MoneyLogHandlers.AddMoneyLogEntry;

public record AddMoneyLogEntryRequest(int Amount, string Type, string Subject, DateTime? DateTime = default)
{
    public MoneyLogEntry ToMoneyLogEntry()
    {
        return new MoneyLogEntry(Guid.NewGuid(), Amount, Type, Subject, DateTime);
    }
}