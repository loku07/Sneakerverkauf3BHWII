using Microsoft.AspNetCore.Mvc;
using SneakerWebApp3BHWII.Models;
using SneakerWebApp3BHWII.Repositories;

namespace SneakerWebApp3BHWII.Controllers;

public class SchuhController : Controller
{
    // GET
    public IActionResult Index()
    {
        SchuhRepository repo = new SchuhRepository();
        List<Schuh> meineSchuhe = repo.GetAllSchuhe();
        
        return View(meineSchuhe);
    }

    public IActionResult Neu()
    {
        
        return View(meineSchuhe);
    }
}