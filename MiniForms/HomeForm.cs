using MiniForms.Assets;
using MiniForms.Modules;
using MiniForms.Modules.Converter;
using MiniForms.Modules.Decrypt;
using MiniForms.Modules.FileIn;
using MiniForms.Modules.FileOut;
using MiniForms.Modules.MailOut;
using MiniForms.Modules.Text_to_PDF;
using MiniForms.Modules.TextReplace;
using MiniForms.Modules.Wordtemplate;
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

        public List<object> TaskList = new List<object>();
        
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string projectFolder = generateProjectFolder();
            // Go through list, execute each module.
            foreach (var task in TaskList)
            {
                if (task is FileInModule fileInModule)
                {
                    fileInModule.Execute(projectFolder);
                    
                }
                // TODO: FileOutToevoegen
               else if(task is FileOutModule fileOutModule)
                {
                    fileOutModule.Execute(projectFolder);
                }
                // TODO: TextReplace toevoegen
                else if(task is TextReplaceModule textReplaceModule)
                {
                    textReplaceModule.Execute(projectFolder);
                }
                else if(task is TexttoPDFModule texttoPDFModule)
                {
                    texttoPDFModule.Execute(projectFolder);
                }
                else
                {
                    throw new Exception("Module vergeten toe te voegen.");
                }
            }
            MessageBox.Show("Modules zijn succesvol uitgevoerd");

            // Lists leegmaken
            TaskList.Clear();
            lvExecute.Items.Clear();
        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // BaseModule newItem = null;

            switch (lvModules.SelectedItems[0].Text)
            {
                case "File In":
                    FileIn();
                    break;

                    // TODO: gelijk maken met FileIn
                case "File Out":
                    FileOut();
                    break;
                case "Text replace":
                    // TODO: Gelijk maken met bovenstaande 
                    TextReplace();
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
                case "Text to PDF":
                    TexttoPDF();
                    break;
                case "Word template":
                    WordtemplateForm wordTemplateForm = new WordtemplateForm();
                    wordTemplateForm.ShowDialog();
                    break;
            }

            
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            btnExecute.Enabled = false;
        }
        private string generateProjectFolder()
        {
            // Setup desination folder
            var projectDirectory = Environment.CurrentDirectory;

            var folderName = Guid.NewGuid().ToString();
            string directory = projectDirectory + "\\Process\\" + folderName;

            // Create project folder/directory
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            return directory;
        }
        private void FileIn() 
        {
            using(var fi = new EditFileInForm())
            {
                DialogResult result = fi.ShowDialog();

                if (result == DialogResult.OK && fi.FileInModule != null) 
                {
                    // Toevoegen aan de lijst.
                    TaskList.Add(fi.FileInModule);
                    lvExecute.Items.Add("FileIn");
                }
            }
        }
        private void FileOut()
        {
            using(var fo = new EditFileOutForm())
            {
                DialogResult result = fo.ShowDialog();
                if(result == DialogResult.OK && fo.FileOutModule != null)
                {
                    //Toevoegen aan de lijst.
                    TaskList.Add(fo.FileOutModule);
                    lvExecute.Items.Add("FileOut");
                }
            }
        }
        private void TextReplace()
        {
            using(var tp = new TextReplaceForm())
            {
                DialogResult result = tp.ShowDialog();
                if(result == DialogResult.OK && tp.TextReplaceModule!= null)
                {
                    TaskList.Add(tp.TextReplaceModule);
                    lvExecute.Items.Add("TextReplace");
                }
            }
        }
        private void TexttoPDF()
        {
            using (var ttpdf = new TexttoPDFForm())
            {
                DialogResult result = ttpdf.ShowDialog();
                if(result == DialogResult.OK && ttpdf.TexttoPDFModule != null)
                {
                    TaskList.Add(ttpdf.TexttoPDFModule);
                    lvExecute.Items.Add("TexttoPDF");
                }
            }
        }

        private void lvModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExecute.Enabled = true;
        }
        
    }
}
