using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Bookish.Models;

namespace Bookish.Controllers;

public class BookCopyController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public BookCopyController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var invisibleWomenCopy1 = new BookCopy
        {
            Book = new Book
            {
                Title = "Invisible Women",
                Author = "Caroline Criado-Perez",
            },

        };

        var invisibleWomenCopy2 = new BookCopy
        {
            Book = new Book
            {
                Title = "Invisible Women",
                Author = "Caroline Criado-Perez",
            },

        };

        var invisibleWomen = new Book
        {
            Title = "Invisible Women",
            Author = "Caroline Criado-Perez",
            Copies = new List<BookCopy> { invisibleWomenCopy1, invisibleWomenCopy2 }
        };
        
        

        // var viewModel = new BookCopyViewModel
        // {
        //     Book = invisibleWomen,
        //     BookCopy = copyInvisibleWomen
        // };

        return View(invisibleWomen);
    }   
}