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
        public bool Execute(string projectFolder)
        {
            // Get files in directory path
            string[] files = Directory.GetFiles(projectFolder);

            if (projectFolder != "")
            {
                foreach (string file in files)
                {
                    var doc = new Document(file);

                    doc.Save(file + ".pdf");

                }
                return true;
            }
            return false;


        }
    }
}
