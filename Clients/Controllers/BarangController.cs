using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using API.Model;
using API.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using static API.ViewModel.BarangVM;

namespace Clients.Controllers
{
    public class BarangController : Controller
    {

        private HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("https://localhost:44356/api/")
        };

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult LoadBarang()
        {
            //client.DefaultRequestHeaders.Add("Authorization", HttpContext.Session.GetString("JWToken"));
            BarangJson data = null;
            var responseTask = client.GetAsync("barang/getbarang");
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                data = JsonConvert.DeserializeObject<BarangJson>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Sorry Server Error, Try Again");
            }

            return Json(data);
        }

        public JsonResult InsertOrUpdate(BarangVM barang)
        {
            var myContent = JsonConvert.SerializeObject(barang);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            if (barang.Id.Equals(0))
            {
                var result = client.PostAsync("barang/", byteContent).Result;
                return Json(result);
            }
            else
            {
                var result = client.PutAsync("barang/" + barang.Id, byteContent).Result;
                return Json(result);
            }
        }

        public JsonResult GetById(int Id)
        {
            //client.DefaultRequestHeaders.Add("Authorization", HttpContext.Session.GetString("JWToken"));
            Barang data = null;
            var responseTask = client.GetAsync("Barang/" + Id);
            responseTask.Wait();
            var result = responseTask.Result;
            if (result.IsSuccessStatusCode)
            {
                var json = JsonConvert.DeserializeObject(result.Content.ReadAsStringAsync().Result).ToString();
                data = JsonConvert.DeserializeObject<Barang>(json);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Sorry Server Error, Try Again");
            }

            return Json(data);
        }
        public JsonResult Delete(int Id)
        {
            //client.DefaultRequestHeaders.Add("Authorization", HttpContext.Session.GetString("JWToken"));
            var result = client.DeleteAsync("Barang/" + Id).Result;
            return Json(result);
        }
    }
}
