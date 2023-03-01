using MiniForms.Assets;
using MiniForms.Modules.FileIn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniForms.Modules.FileOut
{
    public class FileOutModule
    {
        private  string path;
        public FileOutModule(string path)
        {
            this.path = path;
        }
        public bool Execute(string projectFolder)
        {
            if (path != "")
            {
                // Get all files from path
                string[] sourceFilePaths = Directory.GetFiles(path);

                // Loop through the files and copy it
                foreach (string sourceFilePath in sourceFilePaths)
                {
                    var destinationFolderPath = @"C:\Users\Max Staals\source\repos\MiniForms\MiniForms\bin\Debug\net6.0-windows\Temp\";
                    var fileName = Path.GetFileNameWithoutExtension(sourceFilePath);
                    var fileExtension = Path.GetExtension(sourceFilePath);

                    if (sourceFilePath == null)
                        return false;

                    while (File.Exists(destinationFolderPath + fileName + fileExtension))
                    {
                        fileName += " Copy";
                    }

                    // Move file to temp directory
                    //Directory.Move(sourceFilePath, destinationFolderPath + fileName + fileExtension);
                    File.Copy(sourceFilePath, destinationFolderPath + fileName + fileExtension);
                }
            }

            return true;
        }

    }
}
