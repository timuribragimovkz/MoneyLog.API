namespace MoneyLog.Application.Handlers.Interfaces;

public interface IHandler<in TRequest, TResponse>
{
    Task<TResponse> Handle(TRequest request);
}