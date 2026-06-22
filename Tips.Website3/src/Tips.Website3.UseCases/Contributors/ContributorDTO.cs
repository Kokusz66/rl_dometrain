using Tips.Website3.Core.ContributorAggregate;

namespace Tips.Website3.UseCases.Contributors;
public record ContributorDto(ContributorId Id, ContributorName Name, PhoneNumber PhoneNumber);
