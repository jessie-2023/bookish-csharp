using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class BookController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public BookController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        var invisibleWomen = new Book
        {
            Title = "Invisible Women",
            Author = "Caroline Criado-Perez",
        };
        return View(invisibleWomen);
    }
    
}
