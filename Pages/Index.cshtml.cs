using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SQLiteApp.Data;

namespace SQLiteApp.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly DataContext _datacontext;
    public string? RequestId { get; set; }
    public List<ExchangeRate>? lst{get;set;}

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);  
    
    public IndexModel(ILogger<IndexModel> logger,DataContext dataContext)
    {
        try{
        _logger = logger;
        _datacontext=dataContext;
        }
        catch(Exception e)
        {
            RequestId=e.Message;
        }
    }

    public void OnGet()
    {
        try{
            lst = _datacontext.ExchangeRates.ToList();
        }
        catch(Exception e){
            RequestId=e.Message;
        }
    }
}
