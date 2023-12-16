using System.Text.Json;
using System.Text.Json.Serialization;

using Quest.Api.Filter;
using Quest.Logic;

internal class Program {
  private static void Main(string[] args) {
    var builder = WebApplication.CreateBuilder(args);

    ConfigureServices(builder.Services);

    WebApplication app = builder.Build();

    ConfigureMiddleware(app);
    ConfigureEndpoints(app);

    app.Run();
  }

  private static void ConfigureServices(IServiceCollection services) {
    services.AddControllers(options => {
      options.ReturnHttpNotAcceptable = true;
      options.ModelBinderProviders.Insert(0, new PlayerModelBinderProvider(services.BuildServiceProvider().GetService<GameLogic>()));
    }).AddJsonOptions(options => {
      options.JsonSerializerOptions.PropertyNameCaseInsensitive = false;
      options.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
      options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    }).AddXmlDataContractSerializerFormatters();

    services.AddRouting(options => options.LowercaseUrls = true);
    services.AddAutoMapper(typeof(Program));

    services.AddOpenApiDocument(config => config.Title = "SNACKS API");

    services.AddCors(builder =>
      builder.AddDefaultPolicy(policy =>
        policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
      )
    );
    services.AddSingleton<GameLogic>();

    //services.AddHostedService<ScheduledUpdateService>();
  }

  private static void ConfigureMiddleware(IApplicationBuilder app) {
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.UseOpenApi();
    app.UseSwaggerUi3(config => config.Path = "/swagger");
    app.UseCors();
  }

  private static void ConfigureEndpoints(IEndpointRouteBuilder app) {
    app.MapControllers();
  }
}