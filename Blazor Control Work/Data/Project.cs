using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Components.Forms;

namespace Blazor_Control_Work.Data
{
    public class Project
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;

        public string Name;
        public string Customer;
        public string Developer;
        public string Designer;
        public string Dept;

        //Водоснабжение Designer
        [BsonIgnoreIfNull]
        public int dimTryba;
        [BsonIgnoreIfNull]
        public int dlinObject;
        [BsonIgnoreIfNull]
        public int kpdBos;
        [BsonIgnoreIfNull]
        public int countKNS;
        [BsonIgnoreIfNull]
        public int kpdKNS;
        [BsonIgnoreIfNull]
        public int Price;
        [BsonIgnoreIfNull]
        public string dateSrok;

        //Газификация Developer
        [BsonIgnoreIfNull]
        public IBrowserFile PismoPrezident;
        [BsonIgnoreIfNull]
        public IBrowserFile ZadanieProektir;
        [BsonIgnoreIfNull]
        public IBrowserFile Plan;
        [BsonIgnoreIfNull]
        public IBrowserFile TexnYslov;
        [BsonIgnoreIfNull]
        public IBrowserFile TexnPasport;
        [BsonIgnoreIfNull]
        public IBrowserFile TexnPasportKotel;
        [BsonIgnoreIfNull]
        public IBrowserFile AktObsledObject;
        [BsonIgnoreIfNull]
        public IBrowserFile TexnElectro;
        [BsonIgnoreIfNull]
        public IBrowserFile Soglasov;


        public Project(string name, string customer, string developer, string designer, string dept)
        {
            Developer = developer;
            Designer = designer;
            Name = name;
            Dept = dept;
            Customer = customer;
        }

        //Конструктор Designer водоснаюжение
        public Project(string name, string customer, string developer, string designer, string dept, int dimTryba, int dlinObject, int kpdBos, int countKNS, int kpdKNS, int Price,string dateSrok)
        {
            Developer = developer;
            Designer = designer;
            Name = name;
            Customer = customer;
            Dept = dept;
            this.dimTryba = dimTryba;
            this.dlinObject = dlinObject;
            this.kpdBos = kpdBos;
            this.countKNS = countKNS;
            this.kpdKNS = kpdKNS;
            this.Price = Price;
            this.dateSrok = dateSrok;
        }

        public Project(string name, string customer, string developer, string designer, string dept, IBrowserFile pismoPrezident, IBrowserFile zadanieProektir
        , IBrowserFile plan, IBrowserFile texnYslov, IBrowserFile texnPasport, IBrowserFile texnPasportKotel, IBrowserFile aktObsledObject, IBrowserFile texnElectro, IBrowserFile soglasov)
        {
            Developer = developer;
            Designer = designer;
            Name = name;
            Customer = customer;
            Dept = dept;
            ZadanieProektir = zadanieProektir;
            Plan = plan;
            TexnYslov = texnYslov;
            TexnPasport = texnPasport;
            TexnPasportKotel = texnPasportKotel;
            AktObsledObject = aktObsledObject;
            TexnElectro= texnElectro;
            Soglasov = soglasov;
        }
    }
}
