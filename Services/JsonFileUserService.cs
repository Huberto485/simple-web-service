using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using WebAppService.Models;

namespace WebAppService.Services
{
    public class JsonFileUserService
    {
        public JsonFileUserService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JSonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "UserData.json"); }
        }

        public IEnumerable<User> GetUsers()
        {
            using (var jsonFileReader = File.OpenText(JSonFileName))
            {
                return JsonSerializer.Deserialize<User[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}