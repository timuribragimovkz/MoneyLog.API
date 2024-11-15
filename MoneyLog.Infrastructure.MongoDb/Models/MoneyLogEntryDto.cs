using MoneyLog.Domain.LogEntry.Models;
using MoneyLog.Infrastructure.MongoDb.Interfaces;

namespace MoneyLog.Infrastructure.MongoDb.Models;

public class MoneyLogEntryDto : BaseDto, IMapToDto<MoneyLogEntry,MoneyLogEntryDto>, IMapFromDto<MoneyLogEntry>
{
    public DateTime MoneyLogEntryDateTime { get; init; } //auto OR manual assignment
    public int MoneyLogEntryAmount { get; init; } //the amount
    public string? MoneyLogEntryType { get; init; } //should be dynamic: "purchase"
    public string? MoneyLogEntrySubject { get; init; } //"RAM for the PC"
    
    public MoneyLogEntry FromDto()
    {
        return new MoneyLogEntry(
            Id,
            MoneyLogEntryAmount,
            MoneyLogEntryType,
            MoneyLogEntrySubject,
            MoneyLogEntryDateTime);
    }

    public MoneyLogEntryDto ToDto(MoneyLogEntry model)
    {
        return new MoneyLogEntryDto()
        {
            Id = model.Id,
            MoneyLogEntryAmount = model.MoneyLogEntryAmount,
            MoneyLogEntryType = model.MoneyLogEntryType,
            MoneyLogEntrySubject = model.MoneyLogEntrySubject,
            MoneyLogEntryDateTime = model.MoneyLogEntryDateTime
        };
    }
}