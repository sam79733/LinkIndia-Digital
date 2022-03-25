using LinkIndia.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Swashbuckle.AspNetCore.Filters;
using Microsoft.OpenApi.Models;
using LinkIndia.Services.Post;
using LinkIndia.Services.Util;
using LinkIndia.Services.Registration;
using System.Net;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace LinkIndia
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.AllowAnyOrigin()
                                             .AllowAnyMethod()
                                             .AllowAnyHeader();
                                  });
            });

            services.AddDbContext<DataContext>(option => option.UseMySQL(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "linkIndia", Version = "v1" });
                c.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Autherization header using the Bearer scheme. Example: \"bearer {token}\"",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.OperationFilter<SecurityRequirementsOperationFilter>();
            });

            services.AddAutoMapper(typeof(Startup));
            
            services.AddScoped<IRegistration, Registration>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<IUtility, Utility>();

           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "LinkIndia v1"));
            }
         
            app.UseHttpsRedirection();

             app.UseExceptionHandler(
                        options =>
                        {
                            options.Run(async context =>
                            {
                                context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                                context.Response.ContentType = "text/html";
                                var exceptionObject = context.Features.Get<IExceptionHandlerFeature>();
                                if (null != exceptionObject)
                                {
                                    var errorMessage = $"{exceptionObject.Error.Message}";
                                    await context.Response.WriteAsync(errorMessage).ConfigureAwait(false);
                                }
                            });
                        }
                    );


            app.UseRouting();
            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
