using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SneakerWebApp3BHWII.Models;
using SneakerWebApp3BHWII.Repositories;

namespace SneakerWebApp3BHWII.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        SchuhRepository repo = new SchuhRepository();
        List<Schuh> meineSchuhe = repo.GetAllSchuhe();
        return View(meineSchuhe);
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