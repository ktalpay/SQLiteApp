using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SQLiteApp.Pages;

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class ErrorModel : PageModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    private readonly ILogger<ErrorModel> _logger;

    public ErrorModel(ILogger<ErrorModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        try{
//RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
        }
        catch(Exception ex)
        {
            RequestId=ex.Message;
        }
        
    }
}

