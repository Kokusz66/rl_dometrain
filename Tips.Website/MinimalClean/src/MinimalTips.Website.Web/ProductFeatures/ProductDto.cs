using MinimalTips.Website.Web.Domain.ProductAggregate;

namespace MinimalTips.Website.Web.ProductFeatures;
public record ProductDto(ProductId Id, string Name, decimal UnitPrice);
