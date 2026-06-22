using Tips.Website.Core.ContributorAggregate;

namespace Tips.Website.UseCases.Contributors.Delete;

public record DeleteContributorCommand(ContributorId ContributorId) : ICommand<Result>;
