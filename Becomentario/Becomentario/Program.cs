using Microsoft.EntityFrameworkCore;

namespace Becomentario
{
    public class Program
    {
        public Program(IConfiguration configuration)
        {
            Configuration  =  configuration;
        }
        public IConfiguration Configuration { get; }

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
        //public Iconfiguration Configuration{ get;}
    
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("vl", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "Becomentario", Version = "vl" });
            });
            string mySqlConnection = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<AplicationDbcontext>(options =>
                            options.UseMySql(mySqlConnection, ServerVersion.AutoDetect(mySqlConnection)));
        }
    }
}