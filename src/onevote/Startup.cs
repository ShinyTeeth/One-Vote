using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using onevote.Models;
using onevote.Repositories;

namespace onevote
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddDbContext<UserContext>(options =>
            //                   options.UseInMemoryDatabase("onevote"));
            // services.AddDbContext<BallotContext>(options =>
            //                   options.UseInMemoryDatabase("onevote"));
            services.AddTransient<IBallotRepository, BallotRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<ICandidateRepository, CandidateRepository>();
            services.AddTransient<IElectionRepository, ElectionRepository>();
            services.AddMvc();
            services.Configure<MvcOptions>(options =>
            {
                options.Filters.Add(new RequireHttpsAttribute());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseMvc();
        }
    }
}
