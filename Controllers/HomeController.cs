using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var studentInfoArray = new[]
        {
            new StudentInfoModel { Name = "Margaux Cimon Guese", StudentId = "19-1378", StudentAge = "23" },
            new StudentInfoModel { Name = "Japhet Ruiz", StudentId = "21-1991", StudentAge = "20" },
            new StudentInfoModel { Name = "John Partrick Patricio", StudentId = "19-0433", StudentAge = "23" }
        };

        return View(studentInfoArray);
    }
}
