
namespace cartmngr_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
           /* builder.Services.AddAuthentication()
                .AddOAuth("github", o =>
                {
                    o.ClientId = "Ov23li6pkuWBSuaRO4Fo";
                    o.ClientSecret = "934a333cba3bee5024352dd6ec0cb886c48c63a0";
                    o.AuthorizationEndpoint = "https://github.com/login/oauth/authorize";
                    o.TokenEndpoint = "https://github.com/login/oauth/access_token";
                    o.CallbackPath = "/oauth/github-cb";
                    o.UserInformationEndpoint = "https://api.github.com/user";

                }); */

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();



            var app = builder.Build();
           // app.UseAuthentication();
           
            /*
            app.MapGet("/", (
                  HttpContext ctx
                ) =>{
                    return ctx.User.Claims.Select(x => new {x.Type, x.Value}).ToList();

            });

            app.MapGet("/login", (HttpContext ctx) => {

                return Results.Challenge(authenticationSchemes: new List<string>() { "github" });
            });*/
           
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
    }
}
