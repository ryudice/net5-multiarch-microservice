using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System;


await Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(builder =>
    {
        builder.Configure(app =>
        {
            app.UseRouting();
            app.UseEndpoints(r =>
                {
                    r.MapGet("/", ctx => ctx.Response.WriteAsync("Hello"));
                }
            );
        });
    }).Build().RunAsync();