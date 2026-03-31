using System.Diagnostics;
using _06_AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Linuxy.Models;
using Linuxy.Data;

namespace Linuxy.Controllers;

public class UserController : Controller
{
    private readonly ApplicationDbContext _db;

    public UserController(ApplicationDbContext db)
    {
        _db = db;
    }
    
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }
    
    [HttpGet]
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
        
        else
        {
            _db.Users.Add(new User() { Username = username, Password = password });
            _db.SaveChanges();
            
            return Redirect("/User/Login");
        }
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