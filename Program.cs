using StudentRegistrationProject.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy => policy
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod());
});

// Add OpenAPI / Swagger for development-time debugging.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();

var app = builder.Build();

app.UseCors();

// Serve the front-end from wwwroot (index.html, scripts, styles)
app.UseDefaultFiles();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

var students = new List<Student>();

app.MapGet("/api/students", () => Results.Ok(students))
   .WithName("GetStudents");

app.MapPost("/api/students", (CreateStudentRequest request) =>
{
    var student = new Student
    {
        Id = Guid.NewGuid(),
        FirstName = request.FirstName,
        LastName = request.LastName,
        Email = request.Email,
        Age = request.Age,
    };

    students.Add(student);

    return Results.Created($"/api/students/{student.Id}", student);
})
.WithName("CreateStudent");

app.Run();
