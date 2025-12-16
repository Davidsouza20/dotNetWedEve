using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using dotNetWedEve;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<Model.SimpleAuthService>();
builder.Services.AddDbContextFactory<dotNetWedEveContext>(options =>
    options.UseSqlite("Data Source=dotNetWedEve.db"));
builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Antiforgery is required for enhanced forms/endpoints that include anti-forgery metadata
builder.Services.AddAntiforgery();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

// Enable antiforgery middleware so endpoints that carry anti-forgery metadata are handled
app.UseAntiforgery();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

// app.MapRazorComponents<App>()
//     .AddInteractiveServerRenderMode();



app.Run();
