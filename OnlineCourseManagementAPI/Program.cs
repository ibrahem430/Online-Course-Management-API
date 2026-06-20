using OnlineCourseManagementAPI;

var builder = WebApplication.CreateBuilder(args);
builder.Services.Services();
var app = builder.Build();

app.MapControllers();
// app.UseRouting();


app.Run();
