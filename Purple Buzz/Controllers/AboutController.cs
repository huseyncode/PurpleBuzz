using Microsoft.AspNetCore.Mvc;
using Purple_Buzz.Models.About;

namespace Purple_Buzz.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        var model = new AboutIndexVM
        {

            TeamMembers = new List<TeamMemberVM>
            {
            new TeamMemberVM {Name="John", Surname="Doe", Position="Business Development", PhotoPath="/assets/img/team-01.jpg"},
            new TeamMemberVM {Name="John", Surname="Doe", Position="Business Development", PhotoPath="/assets/img/team-02.jpg"},
            new TeamMemberVM {Name="John", Surname="Doe", Position="Developer", PhotoPath="/assets/img/team-03.jpg"}

            }
        };
        return View(model);
    }
}
