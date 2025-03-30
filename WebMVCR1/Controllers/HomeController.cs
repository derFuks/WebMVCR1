using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMVCR1.Models;

namespace WebMVCR1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    // public string Index()
    // {
    //     int hour = DateTime.Now.Hour;
    //     string greeting = hour < 12 ? "Доброе утро" : "Добрый день";
    //     return greeting;
    // }

    public string Index(string name, int num = 1)
    {
        string greeting = $"Здравствуйте, {name}. Это ваш запрос №{num}";
        return greeting;
    }



    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    public IActionResult PersonInfo()
    {
        var person = new Person { Name = "Гонсалес", Age = 83 };
        return View(person);
    }

    
    [HttpGet]
    public IActionResult CreatePerson()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreatePerson(Person person)
    {
        return Content($"Имя: {person.Name}, Возраст: {person.Age}");
    }


    
}
