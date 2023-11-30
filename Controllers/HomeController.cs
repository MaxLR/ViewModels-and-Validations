using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Models;

namespace ViewModels.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("submit")]
    public IActionResult SubmitPet(Pet newPet)
    {
        if(!ModelState.IsValid)
        {
            Console.WriteLine("There was an error");

            // DO NOT REDIRECT WHEN DISPLAYING ERRORS
            // THEY ONLY EXIST FOR ONE REQ/RES CYCLE
            // return Redirect("/");
            
            return View("Index");
        }
        
        Console.WriteLine("Name: " + newPet.Name);
        Console.WriteLine("Type: " + newPet.Type);
        Console.WriteLine("Age: " + newPet.Age);
        Console.WriteLine("Favorite Food: " + newPet.FavoriteFood);

        return View("DisplayPet", newPet);
        // return Redirect("/");
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
}
