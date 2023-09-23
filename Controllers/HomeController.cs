using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Michael C. Camandona", StudentId = "24-1487", StudentAge = "22" },
            new StudentInfoModel { Name = "Marcelo Camandona", StudentId = "10-000", StudentAge = "57" },
            new StudentInfoModel { Name = "Leonora Camandona", StudentId = "10-001", StudentAge = "53" }
        };

        return View(studentInfoArray);
    }
}
