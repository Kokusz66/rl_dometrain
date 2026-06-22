using Tips.Website.Core.ContributorAggregate;

namespace Tips.Website.UseCases.Contributors;
public record ContributorDto(ContributorId Id, ContributorName Name, PhoneNumber PhoneNumber);
