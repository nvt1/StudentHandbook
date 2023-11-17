using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SHB.Domain;
using System.Net.Http.Headers;

namespace SHB.Web.Admin.Controllers
{
    public class UserController : Controller
    {
        private readonly string baseUrl = "https://localhost:7280/";
        public HttpClient CallApi()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(baseUrl);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return client;
        }
        public async Task<ActionResult> Index(int? page)
        {
            var userJson = Request.HttpContext.Session.GetString("Admin");
            if (userJson == null)
            {
                return RedirectToAction("Login", "Authentication");
            }
            int pageSize = 5; // Kích thước trang
            int pageNumber = page ?? 1; // Trang hiện tại (nếu không có, mặc định là trang 1)
            var client = CallApi();
            HttpResponseMessage response = await client.GetAsync("api/user");
            var res = response.Content.ReadAsStringAsync().Result;
            var listUser = JsonConvert.DeserializeObject<List<User>>(res);

            var listUsers = listUser.Where(x => x.Status != 99).ToList();

            var usersToDisplay = listUsers.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            // Tính toán số lượng trang dựa trên tổng số người dùng và kích thước trang
            int totalUsers = listUsers.Count;
            int totalPages = (int)Math.Ceiling((double)totalUsers / pageSize);

            // Truyền giá trị PageCount và PageNumber vào ViewBag
            ViewBag.PageCount = totalPages;
            ViewBag.PageNumber = pageNumber;

            return View(usersToDisplay);
        }

        public async Task<ActionResult> GetUserById(int id)
        {
            var client = CallApi();
            HttpResponseMessage response = await client.GetAsync($"api/user/{id}");
            var user = new User();
            if (response.IsSuccessStatusCode)
            {
                var res = response.Content.ReadAsStringAsync().Result;
                user = JsonConvert.DeserializeObject<User>(res);
            }
            return View(user);
        }

        [HttpGet]
        public async Task<ActionResult> CreateUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateUser(User model)
        {
            var client = CallApi();
            HttpResponseMessage response = await client.PostAsJsonAsync("api/user", model);
            var res = response.Content.ReadAsStringAsync().Result;
            var user = JsonConvert.DeserializeObject<User>(res);
            response.EnsureSuccessStatusCode();
            return RedirectToAction(nameof(GetUserById), "User", new { id = user.Id });
        }
        [HttpGet]
        public async Task<ActionResult> UpdateUser(int id)
        {
            var client = CallApi();
            HttpResponseMessage response = await client.GetAsync($"api/user/{id}");
            var user = new User();
            if (response.IsSuccessStatusCode)
            {
                var res = response.Content.ReadAsStringAsync().Result;
                user = JsonConvert.DeserializeObject<User>(res);
            }
            return View(user);

        }
        [HttpPost]
        public async Task<ActionResult> UpdateUser(User model)
        {
            var client = CallApi();
            HttpResponseMessage response = await client.PutAsJsonAsync($"api/user/{model.Id}", model);
            var res = response.Content.ReadAsStringAsync().Result;
            var user = JsonConvert.DeserializeObject<User>(res);
            response.EnsureSuccessStatusCode();
            return RedirectToAction(nameof(GetUserById), "User", new { id = user.Id });
        }
        public async Task<ActionResult> DeleteUser(int id)
        {
            var client = CallApi();
            HttpResponseMessage response = await client.DeleteAsync($"api/user/{id}");
            response.EnsureSuccessStatusCode();
            return Redirect("Index");
        }
    }
}
