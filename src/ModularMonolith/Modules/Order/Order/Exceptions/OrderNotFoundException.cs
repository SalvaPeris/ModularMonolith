using Shared.Exceptions;

namespace Order.Exceptions
{
    public class OrderNotFoundException(Guid orderId)
         : NotFoundException("Order", orderId) { }
}
