using Aspose.Words;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniForms.Modules.Text_to_PDF
{
    public class TexttoPDFModule
    {
        public bool Execute(string ProjectFolder)
        {
            // Get files in directory path
            string[] files = Directory.GetFiles(ProjectFolder);
            if (ProjectFolder != "")
            {
                foreach (string file in files)
                {
                    var fileExtension = Path.GetExtension(file);
                    if(fileExtension == ".txt")
                    {
                        fileExtension = ".pdf";
                        var doc = new Document(file);
                        doc.Save(file + fileExtension);
                    }
                   

                }
                return true;
            }
            return false;
        }
    }
}
