using Microsoft.AspNetCore.Mvc;
using MoneyLog.Application.Handlers.Interfaces;
using MoneyLog.Application.Handlers.MoneyLogHandlers.AddMoneyLogEntry;
using MoneyLog.Application.Handlers.MoneyLogHandlers.GetMoneyLogEntryById;

namespace MoneyLog.API.EndpointRegistrationExtensions;

public static class EndpointRegistration
{
    public static void MapMoneyLogEndpoints(this WebApplication app)
    {
        app.MapPost(
            "api/3466398E-C93D-4C58-AFA3-7B1639970C8E/add-money-log-entry",
            async ([FromBody]AddMoneyLogEntryRequest request, [FromServices]IHandler<AddMoneyLogEntryRequest, AddMoneyLogEntryResponse> handler) =>
                await handler.Handle(request));
        
        app.MapPost(
            "api/3466398E-C93D-4C58-AFA3-7B1639970C8E/get-money-log-entry-by-id",
            async ([FromBody]GetMoneyLogEntryByIdRequest request, [FromServices]IHandler<GetMoneyLogEntryByIdRequest, GetMoneyLogEntryByIdResponse> handler) =>
            await handler.Handle(request));
    }
}