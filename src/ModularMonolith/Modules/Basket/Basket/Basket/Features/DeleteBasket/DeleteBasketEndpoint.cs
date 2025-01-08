using System.Security.Claims;

namespace Basket.Basket.Features.DeleteBasket
{
    //public record DeleteBasketRequest(string UserName);
    public record DeleteBasketResponse(bool IsSuccess);

    public class DeleteBasketEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/basket", async (ISender sender, ClaimsPrincipal user) =>
            {
                var userName = user.Identity!.Name;

                var result = await sender.Send(new DeleteBasketCommand(userName!));

                var response = result.Adapt<DeleteBasketResponse>();

                return Results.Ok(response);
            })
            .Produces<DeleteBasketResponse>(StatusCodes.Status200OK)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .WithSummary("Delete Basket")
            .WithDescription("Delete Basket")
            .RequireAuthorization();
        }
    }
}
