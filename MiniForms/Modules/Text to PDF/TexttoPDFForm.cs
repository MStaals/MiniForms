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
using static MiniForms.Modules.Decrypt.DecryptForm;

namespace MiniForms.Modules.Text_to_PDF
{
    public partial class TexttoPDFForm : Form
    {
        public TexttoPDFForm()
        {
            InitializeComponent();
        }

        public void converttxttoPDF(string sourcePath, string destPath)
        {

        }

        private void btnConverttoPDF_Click_1(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(@"C:\Users\Max Staals\source\repos\MiniForms\MiniForms\bin\Debug\net6.0-windows\Temp\");

            foreach (string file in files)
            {
                var doc = new Document(file);

                doc.Save(file + ".pdf");
            }
            MessageBox.Show("documenten zijn geconverteerd");
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
