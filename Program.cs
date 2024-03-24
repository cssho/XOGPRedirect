var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (HttpRequest request) =>
 TypedResults.Redirect(
    request.Headers.UserAgent == "Twitterbot/1.0"
        ? "https://github.com/cssho"
        : "https://www.npa.go.jp/bureau/cyber/countermeasures/phishing.html")
);
app.Run();
