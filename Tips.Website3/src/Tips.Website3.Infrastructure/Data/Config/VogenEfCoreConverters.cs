using Tips.Website3.Core.ContributorAggregate;
using Vogen;

namespace Tips.Website3.Infrastructure.Data.Config;

[EfCoreConverter<ContributorId>]
[EfCoreConverter<ContributorName>]
internal partial class VogenEfCoreConverters;
