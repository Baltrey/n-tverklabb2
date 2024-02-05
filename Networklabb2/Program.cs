var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
TeacherCollection collection = new();

app.MapGet("/", () => "Hello");

app.MapGet("/teachers/{number}", collection.GetTeacher);

app.Run();




