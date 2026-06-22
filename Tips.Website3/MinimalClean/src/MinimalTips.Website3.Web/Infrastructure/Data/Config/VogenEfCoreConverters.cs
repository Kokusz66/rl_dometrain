using MinimalTips.Website3.Web.Domain.CartAggregate;
using MinimalTips.Website3.Web.Domain.GuestUserAggregate;
using MinimalTips.Website3.Web.Domain.OrderAggregate;
using MinimalTips.Website3.Web.Domain.ProductAggregate;
using Vogen;

namespace MinimalTips.Website3.Web.Infrastructure.Data.Config;

[EfCoreConverter<ProductId>]
[EfCoreConverter<CartId>]
[EfCoreConverter<CartItemId>]
[EfCoreConverter<GuestUserId>]
[EfCoreConverter<OrderId>]
[EfCoreConverter<OrderItemId>]
[EfCoreConverter<Quantity>]
[EfCoreConverter<Price>]
internal partial class VogenEfCoreConverters;
