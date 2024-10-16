using CurrieTechnologies.Razor.SweetAlert2;
using KioscoInformaticoServices.Interfaces;
using KioscoInformaticoServices.Services;
using KioscoInformaticoWeb;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericService<>));
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<ILocalidadService, LocalidadService>();

builder.Services.AddSweetAlert2();

await builder.Build().RunAsync();
