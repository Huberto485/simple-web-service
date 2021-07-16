using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public void AddUser(string userName, string userEmail, string userTelephone)
        {
            var users = GetUsers();

            var query = users.ToList();

            var lastUser = users.ElementAt(users.Count() - 1);

            int userId = Int32.Parse(lastUser.Id) + 1;

            User newUser = new User()
            {
                Id = userId.ToString(),
                Name = userName,
                Email = userEmail,
                Telephone = userTelephone
            };

            query.Add(newUser);

            using (var outputStream = File.OpenWrite(JSonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<User>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    query
                );
            }
        }

        public void UpdateUser(string userId, string userName, string userEmail, string userTelephone)
        {
            var users = GetUsers();

            var query = users.First(x => x.Id == userId);

            if (userName != null || userName != "")
            {
                query.Name = userName;
            }

            if (userEmail != null || userEmail != "")
            {
                query.Email = userEmail;
            }

            if (userTelephone != null || userTelephone != "")
            {
                query.Telephone = userTelephone;
            }

            using (var outputStream = File.OpenWrite(JSonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<User>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    users
                );
            }
        }

        public void DeleteUser(string userId)
        {
            var users = GetUsers();

            var query = users.ToList();

            int counter = 0;

            while ( query.ElementAt(counter).Id != userId )
            {
                counter += 1;
            }

            query.RemoveAt(counter);

            using (var outputStream = File.Create(JSonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<User>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }),
                    query
                );
            }
        }
    }
}