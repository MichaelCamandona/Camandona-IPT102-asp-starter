using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Michael Camandona", StudentId = "21-1487", StudentAge = "22" },
            new StudentInfoModel { Name = "Leonora Camandona", StudentId = "10-000", StudentAge = "53" },
            new StudentInfoModel { Name = "Marcelo Camandona", StudentId = "10-0001", StudentAge = "57" }
        };

        return View(studentInfoArray);
    }
}
