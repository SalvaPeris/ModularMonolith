using Basket.Basket.Models;
using Shared.Messaging.Events;

namespace Basket.Basket.Mapping
{
    public static class BasketCheckoutMapping
    {
        public static void Mapping()
        {
            TypeAdapterConfig<ShoppingCartItem, ShoppingCartItemIntegration>.NewConfig()
                .Map(dest => dest.ProductId, src => src.ProductId)
                .Map(dest => dest.Quantity, src => src.Quantity)
                .Map(dest => dest.Color, src => src.Color)
                .Map(dest => dest.Price, src => src.Price)
                .Map(dest => dest.ProductName, src => src.ProductName);

            TypeAdapterConfig<ShoppingCart, BasketCheckoutIntegrationEvent>.NewConfig()
                .Map(dest => dest.Items, src => src.Items.Adapt<List<ShoppingCartItemIntegration>>());
        }
    }
}
