using Tips.Website.Core.ContributorAggregate;
using Vogen;

namespace Tips.Website.Infrastructure.Data.Config;

[EfCoreConverter<ContributorId>]
[EfCoreConverter<ContributorName>]
internal partial class VogenEfCoreConverters;
