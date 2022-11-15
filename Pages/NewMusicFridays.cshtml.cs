using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class NewMusicFridaysModel : PageModel
{
    private readonly ILogger<NewMusicFridaysModel> _logger;

    public NewMusicFridaysModel(ILogger<NewMusicFridaysModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
