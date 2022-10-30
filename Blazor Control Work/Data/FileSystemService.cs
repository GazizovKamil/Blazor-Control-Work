using Microsoft.AspNetCore.Components.Forms;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace Blazor_Control_Work.Data
{
    public class FileSystemService
    {
        static public void UploadImageToDb(string filename, string path)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images321");
            var gridFS = new GridFSBucket(database);
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                gridFS.UploadFromStream(filename, fs);
            }
        }

        static public void UploadBrowserImageToDb(FileStream fs, string filename)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images321");
            var gridFS = new GridFSBucket(database);
            gridFS.UploadFromStream(filename, fs);
        }

        static public void DownloadToLocal(User user, string path)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images321");
            var gridFS = new GridFSBucket(database);
            using (FileStream fs = new FileStream(path, FileMode.CreateNew))
            {
                gridFS.DownloadToStreamByName(user.pathImg.Substring(7), fs);
            }
        }
    }
}