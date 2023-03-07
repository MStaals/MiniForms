using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MiniForms.Modules.FileIn
{
    public class FileInModule
    {
        public string Path;

        public FileInModule(string path)
        {
            this.Path = path;
        }

        public  bool Execute(string projectFolder)
        {
            if (Path != "")
            {
                // Get first file in directory path
                var sourceFilePath = Directory.GetFiles(Path).FirstOrDefault();

                var destinationFolderPath = projectFolder + "\\";
                var fileName = System.IO.Path.GetFileNameWithoutExtension(sourceFilePath);
                var fileExtension = System.IO.Path.GetExtension(sourceFilePath);

                if (sourceFilePath == null)
                    return false;

                while (File.Exists(destinationFolderPath + fileName + fileExtension))
                {
                    fileName += " Copy";
                }

                // Move file to temp directory
                Directory.Move(sourceFilePath, destinationFolderPath + fileName + fileExtension);

            }
                return true;
            
        }
       
    }
}
