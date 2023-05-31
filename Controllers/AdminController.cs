using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using occupy.Models;
using occupy.Models.Entities;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace occupy.Controllers;

public class AdminController : Controller
{
    private readonly ILogger<AdminController> _logger;

    public AdminController(ILogger<AdminController> logger)
    {
        _logger = logger;
    }

    ParamatordbContext db = new ParamatordbContext();

    [Authorize]
    public IActionResult Index()
    {
        var model = new IndexViewModel() { Site = db.Sites!.FirstOrDefault(), };
        return View(model);
    }

    [Route("/signin")]
    public IActionResult SignIn()
    {
        var model = new IndexViewModel() { Site = db.Sites!.FirstOrDefault(), };
        return View(model);
    }

    [HttpPost]
    [IgnoreAntiforgeryToken]
    [Route("/admin/signin")]
    public async Task<IActionResult> SignIn(User postedData)
    {
        User user = db.Users!.FirstOrDefault(
            x => x.Username == postedData.Username && x.Password == postedData.Password
        )!;

        if (user != null)
        {
            var claims = new List<Claim>()
            {
                new Claim("user", user.Id.ToString()),
                new Claim("role", "admin")
            };

            var claimsIdentity = new ClaimsIdentity(claims, "Cookies");
            var claimsPrinciple = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(claimsPrinciple);

            TempData["SuccessSignIn"] = "Giriş yapıldı.";
            return RedirectToAction("Index");
        }
        else
        {
            TempData["Danger"] = "Hatalı kullanıcı adı ve ya şifre.";
            return Redirect("/signin");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
