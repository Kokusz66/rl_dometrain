using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using WebAppTest.Client.RenderModes;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddHttpClient();
await builder.Build().RunAsync();
