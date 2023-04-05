using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dojoForm.Models;

namespace dojoForm.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("/privacy")]
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpPost("/addStudent")]
    public IActionResult AddStudent(Student newStudent)
    {
        if (!ModelState.IsValid)
        {
            System.Console.WriteLine(newStudent.Name);
            return View("Index", newStudent);
        }

        if (newStudent.Location == "Fuji")
        {
            ViewBag.SecretMessage = "You picked the secret location Fugi!";
            return View("Index");
        }
        Console.WriteLine(newStudent.Name + " is located in" + newStudent.Location + " and has this to say" + newStudent.Comment);
        // return RedirectToAction("Index");
        // return Redirect("/");
        return View("ViewStudent", newStudent);
    }

    [HttpGet("{**path}")]
    public RedirectToActionResult Unknown()
    {
        Console.WriteLine("Page not found");
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
