using MinimalTips.Website3.Web.Domain.CartAggregate;

namespace MinimalTips.Website3.Web.CartFeatures;

public record CartDto(CartId Id, IReadOnlyList<CartItemDto> Items, decimal Total);

public record CartItemDto(int ProductId, int Quantity, decimal UnitPrice, decimal TotalPrice);
