var webApplicationBuilder = WebApplication.CreateBuilder(args);

webApplicationBuilder.Services.AddCors(options => options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

webApplicationBuilder.Services.AddAuthentication();

webApplicationBuilder.Services.AddAuthorization();

webApplicationBuilder.Services.AddRouting();

webApplicationBuilder.Services.AddControllers();

var webApplication = webApplicationBuilder.Build();

webApplication.UseHttpsRedirection();

webApplication.UseCors();

webApplication.UseAuthentication();

webApplication.UseAuthorization();

webApplication.UseRouting();

webApplication.MapControllers();

webApplication.Run();
