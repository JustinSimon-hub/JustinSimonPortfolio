var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Serve static files from wwwroot
app.UseDefaultFiles();  // Makes index.html the default page
app.UseStaticFiles();   // Enables serving CSS and JS

app.Run();
