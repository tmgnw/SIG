using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static API.ViewModel.JenisBarangVM;

namespace Clients.Controllers
{
    public class JenisBarangController : Controller
    {
        private HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:44356/api/")
        };

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult LoadJenisBarang()
        {
            //client.DefaultRequestHeaders.Add("Authorization", HttpContext.Session.GetString("JWToken"));
            Jenis_BarangJson data = null;
            var responseTask = client.GetAsync("JenisBarang");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                data = JsonConvert.DeserializeObject<Jenis_BarangJson>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Sorry Server Error, Try Again");
            }

            return Json(data);
        }
    }
}
