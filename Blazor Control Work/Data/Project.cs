using MongoDB.Bson.Serialization.Attributes;

namespace Blazor_Control_Work.Data
{
    public class Project
    {
        public string Name;
        public string Developer;
        public string Designer;
        public string Dept;

        //Водоснабжение
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

        public Project(string name, string developer, string designer, string dept)
        {
            Developer = developer;
            Designer = designer;
            Name = name;
            Dept = dept;
        }

        public Project(string name, string developer, string designer, string dept, int dimTryba, int dlinObject, int kpdBos, int countKNS, int kpdKNS, int Price,string dateSrok)
        {
            Developer = developer;
            Designer = designer;
            Name = name;
            Dept = dept;
        }

        public Project(string name)
        {
            Name = name;
        }
    }
}
