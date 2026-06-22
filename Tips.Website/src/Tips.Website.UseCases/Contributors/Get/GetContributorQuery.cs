using Tips.Website.Core.ContributorAggregate;

namespace Tips.Website.UseCases.Contributors.Get;

public record GetContributorQuery(ContributorId ContributorId) : IQuery<Result<ContributorDto>>;
