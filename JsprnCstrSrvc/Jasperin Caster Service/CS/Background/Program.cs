var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//start here
app.MapGet("/send", HTMLfile.ShowHTMLforSend);
app.MapGet("/processid", HTMLfile.ShowHTMLforProcessid);
app.MapGet("/", HTMLfile.ShowHTMLforMain);
//makes all the subdirs
app.Run("http://localhost:6899");
//start the web app
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
//file links for subdirs


//fetch system
//waits for checkstate to = 1 then fetches alertvar's number and sets checkstate(coming soon) to 1 so that main knows when to fetch alertvar