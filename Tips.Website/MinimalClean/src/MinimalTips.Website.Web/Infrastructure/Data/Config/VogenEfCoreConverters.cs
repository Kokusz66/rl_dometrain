using MinimalTips.Website.Web.Domain.CartAggregate;
using MinimalTips.Website.Web.Domain.GuestUserAggregate;
using MinimalTips.Website.Web.Domain.OrderAggregate;
using MinimalTips.Website.Web.Domain.ProductAggregate;
using Vogen;

namespace MinimalTips.Website.Web.Infrastructure.Data.Config;

[EfCoreConverter<ProductId>]
[EfCoreConverter<CartId>]
[EfCoreConverter<CartItemId>]
[EfCoreConverter<GuestUserId>]
[EfCoreConverter<OrderId>]
[EfCoreConverter<OrderItemId>]
[EfCoreConverter<Quantity>]
[EfCoreConverter<Price>]
internal partial class VogenEfCoreConverters;
