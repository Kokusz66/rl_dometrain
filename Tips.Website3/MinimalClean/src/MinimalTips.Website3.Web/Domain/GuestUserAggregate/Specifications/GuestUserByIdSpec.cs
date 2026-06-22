namespace MinimalTips.Website3.Web.Domain.GuestUserAggregate.Specifications;

public class GuestUserByIdSpec : Specification<GuestUser>
{
  public GuestUserByIdSpec(GuestUserId guestUserId) =>
    Query.Where(g => g.Id == guestUserId);
}