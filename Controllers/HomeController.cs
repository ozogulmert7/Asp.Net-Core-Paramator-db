using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using occupy.Models;
using occupy.Models.Entities;

namespace occupy.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    ParamatordbContext db = new ParamatordbContext();

    public IActionResult Index()
    {
        var model = new IndexViewModel()
        {
            Services = db.Services!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
            Abouts = db.Abouts!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
            Slides = db.Slides!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
            Site = db.Sites!.FirstOrDefault(),
            Teams = db.Teams!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
            Messages=db.Messages!.OrderBy(x=>x.Order).Where(x=>x.Isview==true).ToList(),
        };
        return View(model);
    }

    [Route("/about-us")]
    public IActionResult About()
    {
        var model = new IndexViewModel()
        {
            Teams = db.Teams!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
            About = db.Abouts!.FirstOrDefault(x => x.Isview == true),
            Abouts = db.Abouts!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
            Site = db.Sites!.First(),
            Service = db.Services!.FirstOrDefault(x => x.Isview == true),
            Services = db.Services!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
            Messages=db.Messages!.OrderBy(x=>x.Order).Where(x=>x.Isview==true).ToList(),
        };
        return View(model);
    }

    [Route("/service")]
    public IActionResult Service()
    {
        var model = new IndexViewModel()
        {
            Site = db.Sites!.First(),
            Success = db.Successes!.FirstOrDefault(x => x.Isview == true),
            Successes = db.Successes!.OrderBy(x => x.Order).Where(x => x.Isview == true).ToList(),
        };
        return View(model);
    }

    [Route("/blog")]
    public IActionResult Blog()
    {
        var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);
    }

    [Route("/blog-single/{title}/{id}")]
    public IActionResult BlogSingle(string title, int id)
    {
        var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);
    }

    [Route("/cource")]
    public IActionResult Cource()
    {
        var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);
    }

    [Route("/cource-single/{title}/{id}")]
    public IActionResult CourceSingle(string title, int id)
    {
        var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);
    }

    [Route("/event")]
    public IActionResult Event()
    {
        var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);
    }

    [Route("/event-single/{title}/{id}")]
    public IActionResult EventSingle(string title, int id)
    {
        var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);
    }

    [Route("/contact")]
    public IActionResult Contact()
    {
        var model = new IndexViewModel() { Site = db.Sites!.First() };
        return View(model);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
