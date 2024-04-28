using Microsoft.EntityFrameworkCore;
using TaylorSwiftAlbumRanker.Client.Pages;
using TaylorSwiftAlbumRanker.Components;
using TaylorSwiftAlbumRanker.Data;
using TaylorSwiftAlbumRanker.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))); //register your db connection

builder.Services.AddScoped<IUsersService, UsersService>(); //register user service
builder.Services.AddScoped<IAlbumsService, AlbumsService>();

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

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(TaylorSwiftAlbumRanker.Client._Imports).Assembly);

app.Run();
