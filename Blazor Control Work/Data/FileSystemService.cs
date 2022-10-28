using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace Blazor_Control_Work.Data
{
    public class FileSystemService
    {
        public void UploadImageToDb(string namePhoto, string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images321");
            var gridFS = new GridFSBucket(database);

            using (FileStream fs = new FileStream("C:\\Users\\Камиль\\Desktop\\image\\"+ namePhoto, FileMode.Open))
            {
                gridFS.UploadFromStream($"{name}.jpg", fs);
            }
        }

        public void DownloadToLocal(string name)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images321");
            var gridFS = new GridFSBucket(database);
            using (FileStream fs = new FileStream($"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Images/")}{name}+{"New"}.jpg", FileMode.CreateNew))
            {
                gridFS.DownloadToStreamByName($"{name}.jpg", fs);
            }
        }
    }
}