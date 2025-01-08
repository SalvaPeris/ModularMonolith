using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Basket.Basket.Features.AddItemIntoBasket
{
    public record AddItemIntoBasketRequest(string UserName, ShoppingCartItemDto ShoppingCartItem);
    public record AddItemIntoBasketResponse(Guid Id);

    public class AddItemIntoBasketEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/basket/items",
                async ([FromBody] AddItemIntoBasketRequest request,
                       ISender sender,
                       ClaimsPrincipal user) =>
                {
                    var userName = user.Identity!.Name;

                    var command = new AddItemIntoBasketCommand(userName!, request.ShoppingCartItem);

                    var result = await sender.Send(command);

                    var response = result.Adapt<AddItemIntoBasketResponse>();

                    return Results.Created($"/basket/{response.Id}", response);
                })
            .Produces<AddItemIntoBasketResponse>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Add Item Into Basket")
            .WithDescription("Add Item Into Basket")
            .RequireAuthorization();
        }
    }
}
