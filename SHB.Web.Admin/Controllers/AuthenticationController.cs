using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SHB.Domain;
using System.Net.Http.Headers;

namespace SHB.Web.Admin.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly string baseUrl = "https://localhost:7280/";
        List<User> listUser = new List<User>();
        public HttpClient CallApi()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Login(IFormCollection collection)
        {
            var client = CallApi();
            var sEmail = collection["Email"].ToString();
            var sPassword = collection["Password"].ToString();
            ViewBag.Email = "";
            if (String.IsNullOrEmpty(sEmail))
            {
                ViewData["Err1"] = "Bạn chưa nhập tên đăng nhập";
                return View();
            }
            else if (String.IsNullOrEmpty(sPassword))
            {
                ViewData["Err2"] = "Phải nhập mật khẩu";
                return View();
            }
            else
            {
                HttpResponseMessage response = await client.GetAsync("api/User");

                if (response.IsSuccessStatusCode)
                {
                    var res = response.Content.ReadAsStringAsync().Result;
                    listUser = JsonConvert.DeserializeObject<List<User>>(res);

                }
                var ad = listUser.FirstOrDefault(n => n.Email == sEmail && n.Password == sPassword);
                if (ad != null)
                {
                    ViewBag.ThongBao = "Chúc mừng đăng nhập thành công  ";
                    HttpContext.Session.SetString("Admin", JsonConvert.SerializeObject(ad));
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không chính xác";
                    return View();
                }
            }

        }
        public ActionResult Logout()
        {
            HttpContext.Session.Remove("Admin");
            return RedirectToAction("Login", "Authentication");
        }
    }
}
