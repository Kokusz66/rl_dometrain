using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace AppTOTest.IntegrationsTests
{
    public class CustomWebApplicationFactory<TProgram> : WebApplicationFactory<TProgram>
        where TProgram : class
    {

    }
}