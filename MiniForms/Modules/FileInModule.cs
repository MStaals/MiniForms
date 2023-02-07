using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MiniForms.Modules
{
    public class FileInModule
    {
        private readonly string path;
        private readonly string projectFolder;

        public FileInModule(string path, string projectFolder)
        {
            this.path = path;
            this.projectFolder = projectFolder;
        }

        public bool Execute()
        {
            // Get first file in directory path
            var file = Directory.GetFiles(this.path).FirstOrDefault();


            if (file == null)
                return false;

            // Move file to temp directory
            Directory.Move(file, this.projectFolder + "\\" + Path.GetFileName(file));
            // Replace name if needed. 

            // Remove file from path.

            return true;
        }
    }
}
