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
        public string Patronymic { get; set; }
        public string Email {get; set;}
        public string PhoneNumber { get; set; }
        public string Dept { get; set; }
        public string Post { get; set; }


        public User(string login, string password, string name,string surname, string patronymic, string email, string phoneNumber, string dept, string post)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Email = email;
            PhoneNumber = phoneNumber;
            Dept = dept;
            Post = post;
        }

        public User(string login, string password, string name, string surname, string patronymic)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
        }
    }
}
