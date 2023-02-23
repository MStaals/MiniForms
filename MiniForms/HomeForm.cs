using MiniForms.Assets;
using MiniForms.Modules;
using MiniForms.Modules.Converter;
using MiniForms.Modules.Decrypt;
using MiniForms.Modules.FileIn;
using MiniForms.Modules.FileOut;
using MiniForms.Modules.MailOut;
using MiniForms.Modules.TextReplace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MiniForms
{
    public partial class HomeForm : Form
    {

        //public List<BaseModule> TaskList = new List<BaseModule>();

        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {

        }
        

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           // BaseModule newItem = null;

            switch (lvModules.SelectedItems[0].Text)
            {
                case "File In":
                    EditFileInForm editFileInForm = new EditFileInForm();
                    editFileInForm.ShowDialog();
                    break;

                case "File Out":
                    EditFileOutForm editFileOutForm = new EditFileOutForm();
                    editFileOutForm.ShowDialog();
                    break;
                case "Text replace":
                    TextReplaceForm textReplaceForm = new TextReplaceForm();
                    textReplaceForm.ShowDialog();
                    break;
                case "Mail Out":
                    MailOutForm mailOutForm = new MailOutForm();
                    mailOutForm.ShowDialog();
                    break;
                case "Converter":
                    ConverterForm converterForm = new ConverterForm();
                    converterForm.ShowDialog();
                    break;
                case "Decrypt":
                    DecryptForm decryptForm = new DecryptForm();
                    decryptForm.ShowDialog();
                    break;
            }

            //TaskList.Add(newItem);
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
