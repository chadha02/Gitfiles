using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddMemoryCache();

using IHost host = builder.Build();

IMemoryCache cache = host.Services.GetRequiredService<IMemoryCache>();

const string cacheKey = "welcome-message";
string message = cache.GetOrCreate(cacheKey, entry =>
{
    entry.AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(10);
    return "Your .NET app is ready. Start coding in Program.cs.";
})!;

Console.WriteLine(message);
