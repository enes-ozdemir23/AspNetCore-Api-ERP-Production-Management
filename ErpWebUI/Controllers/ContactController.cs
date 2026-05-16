using ErpWebUI.Dtos.ContactDtos;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ErpWebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto createContactDto)
        {
            createContactDto.Status = false;
            createContactDto.Date= DateTime.Now;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createContactDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7196/api/Contacts", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                TempData["Success"] = "Mesajınız başarıyla gönderildi.";
                return RedirectToAction("Index");
            }
            TempData["Error"] = "Mesaj gönderilemedi, lütfen tekrar deneyin.";
            return View();
        }
    }
}

