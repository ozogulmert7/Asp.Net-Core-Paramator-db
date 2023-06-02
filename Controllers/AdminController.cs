﻿using System.Diagnostics;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using occupy.Models.Entities;
using occupy.Models;

namespace Paramotor.Controllers;

[Authorize]
public class AdminController : Controller
{
    private readonly ILogger<AdminController> _logger;

    public AdminController(ILogger<AdminController> logger)
    {
        _logger = logger;
    }

    ParamotordbContext db = new ParamotordbContext();

    [Authorize]
    public IActionResult Index()
    {
        return View();
    }

    [AllowAnonymous]
    [Route("/admin/login")]
    public IActionResult Login()
    {
        return View();
    }

    [AllowAnonymous]
    [HttpPost]
    [IgnoreAntiforgeryToken]
    [Route("/admin/login")]
    public async Task<IActionResult> Login(User postedData)
    {
        User user = db.Users!.FirstOrDefault(
            x => x.Email == postedData.Email && x.Password == postedData.Password
        )!;

        if (user != null)
        {
            var claims = new List<Claim>
            {
                new Claim("user", user.Id.ToString()),
                new Claim("role", "admin")
            };

            var claimsIdendity = new ClaimsIdentity(claims, "Cookies", "user", "role");
            var claimsPrinciple = new ClaimsPrincipal(claimsIdendity);
            await HttpContext.SignInAsync(claimsPrinciple);
            return Redirect("/admin/");
        }
        else
        {
            TempData["Danger"] = "Hatalı Kullanıcı Adı / Şifre";
            return Redirect("/admin/login");
        }
    }

    [Route("/signout")]
    public async Task<IActionResult> Signout()
    {
        await HttpContext.SignOutAsync();
        TempData["Success"] = "Tekrar Bekleriz";
        return Redirect("/admin/login");
    }

    [Authorize]
    [Route("/admin/team/edit/")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
