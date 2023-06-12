using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using BlazorTest.Data;
using MudBlazor.Services;
<<<<<<< HEAD

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
=======
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorTest;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();


await builder.Build().RunAsync();




/*// Add services to the container.
>>>>>>> d96c229193e3fd9d969850aafc182d7650d53470
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddMudServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

<<<<<<< HEAD
app.Run();
=======
app.Run(); */

>>>>>>> d96c229193e3fd9d969850aafc182d7650d53470

