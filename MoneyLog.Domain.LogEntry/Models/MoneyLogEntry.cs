using MoneyLog.Domain.Common.Models;

namespace MoneyLog.Domain.LogEntry.Models;

public class MoneyLogEntry : BaseDomainModel
{
    public int MoneyLogEntryAmount { get; init; } //the amount
    public string MoneyLogEntryType { get; init; } //should be dynamic: "purchase"
    public string MoneyLogEntrySubject { get; init; } //"RAM for the PC"
    public DateTime MoneyLogEntryDateTime { get; init; } //auto OR manual assignment
    
    public MoneyLogEntry(
        Guid id,
        int moneyLogEntryAmount, 
        string? moneyLogEntryType, 
        string? moneyLogEntrySubject, 
        DateTime? moneyLogEntryDateTime = null)
    {
        Id = id;
        MoneyLogEntryAmount = moneyLogEntryAmount;
        MoneyLogEntryType = moneyLogEntryType ?? "default";
        MoneyLogEntrySubject = moneyLogEntrySubject ?? "default";
        MoneyLogEntryDateTime = moneyLogEntryDateTime ?? DateTime.Now;
    }
    
}