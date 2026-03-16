using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    public IActionResult Index()
    {
        var user = HttpContext.Session.GetString("user");

        if (user != null)
        {
            return RedirectToAction("Index", "Home");
        }

        return View();
    }

    [HttpPost]
    public IActionResult DoLogin(string username, string password)
    {
        if (username == "admin" && password == "123")
        {
            HttpContext.Session.SetString("user", username);

            return RedirectToAction("Index", "Home");
        }

        ViewBag.Error = "Sai tài khoản";
        return View("Index");
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }
}