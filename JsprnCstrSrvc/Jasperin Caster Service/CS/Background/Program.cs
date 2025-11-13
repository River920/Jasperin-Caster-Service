var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/send", HTMLfile.ShowHTML);

app.Run("http://localhost:6899");

static class HTMLfile
{
    public static async Task<IResult> ShowHTML()
    {
        var html = await File.ReadAllTextAsync("display.html");
        return Results.Content(html, "text/html");
    }
}