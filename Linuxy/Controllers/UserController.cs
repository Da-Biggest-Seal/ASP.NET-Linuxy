using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Linuxy.Models;

namespace Linuxy.Controllers;

public class UserController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
    
    public IActionResult Signin()
    {
        return View();
    }
    
    public IActionResult AfterLogin()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}