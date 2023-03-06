using Aspose.Words;
using Aspose.Words.Reporting;
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
            string[] files = Directory.GetFiles(projectFolder);
            for (int i = 0; i < files.Length; i++)
            {
                string MyDir = @"C:\Users\Max Staals\Documents\Template\";
                Document docTemplate = new(MyDir + "DocTemplate.dotx");
                Document doc = new(files[i]);
                DocumentBuilder builder = new(docTemplate);
                builder.Write(doc.Document.GetText());

                if (projectFolder != "")
                {
                    foreach (string file in files)
                    {
                        var fileExtension = Path.GetExtension(file);
                        if (fileExtension == ".docx")
                        {
                            ReportingEngine engine = new();
                            engine.BuildReport(docTemplate, builder);
                            docTemplate.Save(files[i]);
                        }
                    }
                }
            }
            return false;
        }
    }
}
