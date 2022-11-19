# [BerkC.ImageToWebP](https://www.nuget.org/packages/BerkC.ImageToWebP/1.0.0) [![NuGet version](https://badge.fury.io/nu/BerkC.ImageToWebP.svg)](https://badge.fury.io/nu/BerkC.ImageToWebP)

### Example for how to use

```C# 
public void ConfigureServices(IServiceCollection services)
{
    services.AddImageSharp(c => c.OnParseCommandsAsync += context =>
    {
        if (context.Context.IsImageRequest() && context.Context.IsWebPAccepted())
        {
            context.Commands.Add("format", "webp");
        }
        return Task.CompletedTask;
    });
}

public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    app.UseImageSharp();
}
```