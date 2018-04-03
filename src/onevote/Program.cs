using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace onevote
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseKestrel(options =>
                {
                    //Bind on all IPs to port 443. 
                    //This forces everything be served over HTTPS, as nothing is bound to port 80.
                    options.Listen(IPAddress.Any, 443, listenOptions =>
                    {
                        listenOptions.UseHttps("onevote-ssl.p12", "onevote");
                    });
                })
                //.UseUrls("https://localhost:44300") //this is overridden by options in Kestrel
                .UseStartup<Startup>()
                .Build();
    }
}
