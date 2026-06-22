using Vogen;

[assembly: VogenDefaults(
        staticAbstractsGeneration: StaticAbstractsGeneration.MostCommon | StaticAbstractsGeneration.InstanceMethodsAndProperties)]


namespace Tips.Website3.Core.ContributorAggregate;

[ValueObject<int>]
public readonly partial struct ContributorId
{
  private static Validation Validate(int value)
      => value > 0 ? Validation.Ok : Validation.Invalid("ContributorId must be positive.");
}
