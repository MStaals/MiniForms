using Aspose.Words;
using Aspose.Words.Reporting;
using Microsoft.VisualBasic.ApplicationServices;
using MiniForms.Modules.Text_to_PDF;
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
        public WordTemplateModule WordTemplateModule { get; set; }
        public WordtemplateForm()
        {
            InitializeComponent();
        }


        private void btnTemplate_Click(object sender, EventArgs e)
        {
            WordTemplateModule = new WordTemplateModule();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
