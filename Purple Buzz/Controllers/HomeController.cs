using Microsoft.AspNetCore.Mvc;
using Purple_Buzz.Data;
using Purple_Buzz.Models.Home;

namespace Purple_Buzz.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;
    public HomeController(AppDbContext context)
    {
        _context = context;

    }
    public IActionResult Index()
    {
        var services = _context.Services.ToList();
        var servicesList = new List<ServiceVM>();
        foreach (var service in services)
        {
            var serviceVM = new ServiceVM{
                Name = service.Name,
                Description = service.Description,
                PhotoPath = service.PhotoPath,
                Type= service.Type
            };
            servicesList.Add(serviceVM);
        }
        var model = new HomeIndexVM
        {
            Services = servicesList
        };
        return View(model);
    }
}
