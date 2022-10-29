using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace Blazor_Control_Work.Data
{
    public class FileSystemService
    {
        public void UploadImageToDb(Stream filestr)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images321");
            var gridFS = new GridFSBucket(database);

            gridFS.UploadFromStream("photo.jpg", filestr);
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