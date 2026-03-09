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
    
    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            ViewData["error"] = "Není zadán username a password";
            
            return View();
        }
        
        /*
        else if (password != )

        {
            ViewData["error"] = "Hesla se neschodují";
            return View();
        }
        */
        
        else return View();
    }
    
    [HttpPost]
    public IActionResult Signin(string username, string password, string checkPassword)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            ViewData["error"] = "Není zadán username a password";
            
            return View();
        }
        
        else if (password != checkPassword)

        {
            ViewData["error"] = "Hesla se neschodují";
            return View();
        }
        
        else return View();
    }
    
    public IActionResult AfterLogin()
    {
        return View();
    }
    
    public IActionResult Main()
    {
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}