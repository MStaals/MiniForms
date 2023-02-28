using Aspose.Words;
using Aspose.Words.Reporting;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniForms.Modules.Wordtemplate
{
    public partial class WordtemplateForm : Form
    {
        public WordtemplateForm()
        {
            InitializeComponent();
        }


        private void btnTemplate_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"C:\Users\Max Staals\source\repos\MiniForms\MiniForms\bin\Debug\net6.0-windows\Temp\");
            string MyDir = @"C:\Users\Max Staals\Documents\Template\";
            
            
            Document doc = new Document(MyDir + "DocTemplate.dotx");

            foreach (string file in files)
            {
                doc.AttachedTemplate = MyDir + "DocTemplate.dotx";

                doc.Save(file);
            }
            MessageBox.Show("Template is succesvol toegepast");
            this.Close();
        }
    }
}
