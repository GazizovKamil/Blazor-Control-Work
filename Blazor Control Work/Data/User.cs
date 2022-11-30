using Microsoft.AspNetCore.Identity;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

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
        [BsonIgnoreIfDefault]
        public string Email {get; set;}
        public string Role { get; set; }
        [BsonIgnoreIfDefault]
        public string PhoneNumber { get; set; }
        [BsonIgnoreIfDefault]
        public string Dept { get; set; }
        [BsonIgnoreIfDefault]
        public string Post { get; set; }
        [BsonIgnoreIfDefault]
        public string Developer { get; set; }
        [BsonIgnoreIfDefault]
        public string Designer { get; set; }
        [BsonIgnoreIfDefault]
        public int OGRN { get; set; }
        [BsonIgnoreIfDefault]
        public int INN { get; set; }
        [BsonIgnoreIfDefault]
        public int KPP { get; set; }
        [BsonIgnoreIfDefault]
        public string Adres { get; set; }
        [BsonIgnoreIfDefault]
        public string GIP { get; set; }



        public User(string login, string password, string name, string surname, string patronymic, string email, string phoneNumber, string dept, string post, string role)
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
            Role = role;
        }

        public User(string login, string password, string name, string surname, string patronymic, string role)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Role = role;
        }

        public User(string login, string password, string name, string surname, string patronymic, string role, string developer, int ogrn, int inn, int kpp, string adres, string email, string phoneNumber)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Role = role;
            Developer = developer;
            OGRN = ogrn;
            INN = inn;
            KPP = kpp;
            Adres = adres;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public User(string login, string password, string name, string surname, string patronymic, string role, string designer, int ogrn, int inn, int kpp, string adres, string email, string phoneNumber, string gip)
        {
            Login = login;
            Password = password;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Role = role;
            Designer = designer;
            OGRN = ogrn;
            INN = inn;
            KPP = kpp;
            Adres = adres;
            Email = email;
            PhoneNumber = phoneNumber;
            GIP = gip;
        }


        [BsonIgnoreIfDefault]
        public List<Project> projects = new List<Project>();

        public void AddProject(Project project)
        {
            projects.Add(project);
        }
    }
}
