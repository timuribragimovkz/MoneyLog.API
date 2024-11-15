namespace MoneyLog.Infrastructure.MongoDb.Exceptions;

public class BaseMongoDbException : Exception
{
    public BaseMongoDbException(string message):base(message){}
}