using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Blazor_Control_Work.Data
{
    public class User
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        public string Login {get; set;}
        public string Password {get; set;}
        public string Name {get; set;}
        public string Surname {get; set;}
        public string Email {get; set;}

        public User(string login, string password, string name, string surname, string email)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Email = email;
        }
    }
}
