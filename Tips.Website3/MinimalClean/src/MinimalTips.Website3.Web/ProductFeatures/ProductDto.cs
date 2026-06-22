using MinimalTips.Website3.Web.Domain.ProductAggregate;

namespace MinimalTips.Website3.Web.ProductFeatures;
public record ProductDto(ProductId Id, string Name, decimal UnitPrice);
