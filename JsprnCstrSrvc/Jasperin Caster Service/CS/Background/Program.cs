var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/send", HTMLfile.ShowHTMLforSend);
app.MapGet("/processid", HTMLfile.ShowHTMLforProcessid);
app.MapGet("/", HTMLfile.ShowHTMLforMain);

app.Run("http://localhost:6899");

static class HTMLfile
{
    public static async Task<IResult> ShowHTMLforSend()
    {
        var html = await File.ReadAllTextAsync("display.html");
        return Results.Content(html, "text/html");
    }

    public static async Task<IResult> ShowHTMLforProcessid()
    {
        var html = await File.ReadAllTextAsync("process_id.html");
        return Results.Content(html, "text/html");
    }

    public static async Task<IResult> ShowHTMLforMain()
    {
        var html = await File.ReadAllTextAsync("main.html");
        return Results.Content(html, "text/html");
    }
}