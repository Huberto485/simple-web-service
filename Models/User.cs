using System;
using System.Text.Json;

namespace WebAppService.Models
{
    public class User
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Telephone { get; set; }

        public override string ToString() => JsonSerializer.Serialize<User>(this);
    }
}
