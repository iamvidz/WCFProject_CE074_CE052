using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AssignmentFiles
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        private const string FILEPATH = @"D:\c#codes";
        private string GetDirectoryPath()
        {
            return FILEPATH;
        }
        public string Upload(System.IO.Stream inputStream)
        {
            string fileID = string.Format(@"{0}\{1}.txt", GetDirectoryPath(), Guid.NewGuid().ToString());
            StreamReader reader = new StreamReader(inputStream);
            string contents = reader.ReadToEnd();
            File.WriteAllText(fileID, contents);
            return fileID;
        }
        public System.IO.Stream Download(string fileId)
        {
            MemoryStream stream = new MemoryStream();
            byte[] buffer = File.ReadAllBytes(fileId);
            stream.Write(buffer, 0, buffer.Length);
            stream.Position = 0;
            return stream;
        }
        public string[] GetAvailableFiles()
        {
            return new DirectoryInfo(GetDirectoryPath()).GetFiles().Select(x => x.FullName).ToArray();
        }
    }
}
