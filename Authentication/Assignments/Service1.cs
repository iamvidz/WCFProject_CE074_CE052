using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignments
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        string path = @"d:\c#codes";
        public Stream Download(string file)
        {
            MemoryStream stream = new MemoryStream();
            var bytes = File.ReadAllBytes(file);
            stream.Write(bytes, 0, bytes.Length);
            stream.Position = 0;
            return stream;
        }

        public string Upload(Stream input)
        {
            string filename = String.Format(@"{0}\{1}.txt", path, Guid.NewGuid().ToString());
            StreamReader reader = new StreamReader(input);
            var content = reader.ReadToEnd();
            File.WriteAllText(filename, content);
            return filename;
        }
    }
}
