using Aspose.Words;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniForms.Modules.Wordtemplate
{
    public class WordTemplateModule
    {
        public bool Execute(string projectFolder)
        {
            // Get files in directory path
            string[] files = Directory.GetFiles(projectFolder);
            string MyDir = @"C:\Users\Max Staals\Documents\Template\";
            Document doc = new Document(MyDir + "DocTemplate.dotx");

            if (projectFolder != "")
            {
                foreach (string file in files)
                {
                    doc.AttachedTemplate = MyDir + "DocTemplate.dotx";
                    doc.Save(file);
                }
                return true;
            }
            return false;
        }
    }
}
