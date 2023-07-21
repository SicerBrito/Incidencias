namespace API.Extensions;
    public static class ApplicationServiceExtension
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options => 
            {
                options.AddPolicy("CorsPolicy",builder=>
                    builder.AllowAnyOrigin()    //WithOrigins("http://domini.com")
                    .AllowAnyMethod()           //WithMethods(*GET", "POST")
                    .AllowAnyHeader());         //WithHeaders(*accept*, "content-type")
            });
    }
