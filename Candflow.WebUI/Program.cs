using Candflow.WebUI;
using Candflow.WebUI.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var webAssemblyHostBuilder = WebAssemblyHostBuilder.CreateDefault(args);

webAssemblyHostBuilder.RootComponents.Add<App>("#app");
webAssemblyHostBuilder.RootComponents.Add<HeadOutlet>("head::after");

webAssemblyHostBuilder.Services.AddAuthorizationCore();

webAssemblyHostBuilder.Services.AddScoped<AuthenticationStateService>();

await webAssemblyHostBuilder.Build().RunAsync();
