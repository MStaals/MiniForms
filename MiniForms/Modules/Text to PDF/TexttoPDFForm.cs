using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using Aspose.Words.Drawing;
using MiniForms.Modules.TextReplace;

namespace MiniForms.Modules.Text_to_PDF
{
    public partial class TexttoPDFForm : Form
    {
        public TexttoPDFModule TexttoPDFModule { get; set; }
        public TexttoPDFForm()
        {
            InitializeComponent();
        }
        private void btnConverttoPDF_Click_1(object sender, EventArgs e)
        {
            TexttoPDFModule = new TexttoPDFModule();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
