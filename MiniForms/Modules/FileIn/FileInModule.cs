using MiniForms.Assets;
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
        public string path;
        public readonly string projectFolder;

        public FileInModule(string path, string projectFolder)
        {
            this.path = path;
            this.projectFolder = projectFolder;
        }

        public  bool Execute()
        {
            if (path != "")
            {
                // Get first file in directory path
                var sourceFilePath = Directory.GetFiles(path).FirstOrDefault();

                var destinationFolderPath = projectFolder + "\\";
                var fileName = Path.GetFileNameWithoutExtension(sourceFilePath);
                var fileExtension = Path.GetExtension(sourceFilePath);

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
