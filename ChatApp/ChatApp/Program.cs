using ChatApp.Client.Pages;
using ChatApp.Components;
using ChatApp.Data.Context;
using ChatApp.Hubs;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
	.AddInteractiveWebAssemblyComponents();

builder.Services.AddSignalR();

builder.Services.AddDbContext<ChatAppDbContext>(options => 
	options.UseSqlite(builder.Configuration.GetConnectionString("ChatDbConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseWebAssemblyDebugging();
}
else
{
	app.UseExceptionHandler("/Error", createScopeForErrors: true);
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}



app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();
app.MapHub<ChatHub>("/chathub");
app.MapRazorComponents<App>()
	.AddInteractiveWebAssemblyRenderMode()
	.AddAdditionalAssemblies(typeof(ChatApp.Client._Imports).Assembly);

app.Run();
