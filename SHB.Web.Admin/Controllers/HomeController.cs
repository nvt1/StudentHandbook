using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SHB.Domain;
using SHB.Web.Admin.Models;
using System.Diagnostics;
using System.Net.Http.Headers;

namespace SHB.Web.Admin.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly string baseUrl = "https://localhost:7280/";


    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<ActionResult> Index()
    {
        var client = new HttpClient();
        client.BaseAddress = new Uri(baseUrl);
        client.DefaultRequestHeaders.Clear();
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        HttpResponseMessage response = await client.GetAsync("api/user");
        var res = response.Content.ReadAsStringAsync().Result;
        var listUser = JsonConvert.DeserializeObject<List<User>>(res);

        return View(listUser);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
