using MoneyLog.Domain.LogEntry.Models;

namespace MoneyLog.Application.Handlers.MoneyLogHandlers.GetMoneyLogEntryById;

public record GetMoneyLogEntryByIdResponse(
    Guid Id,
    int Amount,
    string Type,
    string Subject,
    DateTime DateTime)
{
    public static GetMoneyLogEntryByIdResponse FromMoneyLogEntry(MoneyLogEntry moneyLogEntry)
    {
        return new GetMoneyLogEntryByIdResponse(
            moneyLogEntry.Id,
            moneyLogEntry.MoneyLogEntryAmount,
            moneyLogEntry.MoneyLogEntryType,
            moneyLogEntry.MoneyLogEntrySubject,
            moneyLogEntry.MoneyLogEntryDateTime);
    }
}