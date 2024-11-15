namespace MoneyLog.Domain.Common.Models;

public class BaseDomainModel
{
    public Guid Id { get; init; }
    
    public BaseDomainModel(Guid? id = default)
    {
        Id = id ?? Guid.NewGuid();
    }
    
}