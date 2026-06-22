using Tips.Website3.Core.ContributorAggregate;

namespace Tips.Website3.UseCases.Contributors.Delete;

public record DeleteContributorCommand(ContributorId ContributorId) : ICommand<Result>;
