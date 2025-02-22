﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRDto.MenuTableDto;
using System.Text;

namespace SignalRWebUI.Controllers
{
    public class MenuTableController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MenuTableController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44383/api/MenuTable");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMenuTableDto>>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateMenuTable()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMenuTable(CreateMenuTableDto createMenuTableDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createMenuTableDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:44383/api/MenuTable", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "MenuTable");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateMenuTable(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44383/api/MenuTable/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateMenuTableDto>(jsonData);
                return View(values);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateMenuTable(UpdateMenuTableDto updateMenuTable)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateMenuTable);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:44383/api/MenuTable", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "MenuTable");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> TableListByStatus()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:44383/api/MenuTable");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultMenuTableDto>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
