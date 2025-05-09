﻿using MiniForms.Modules;
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
               else if(task is FileOutModule fileOutModule)
                {
                    fileOutModule.Execute(projectFolder);
                }
                else if(task is TextReplaceModule textReplaceModule)
                {
                    textReplaceModule.Execute(projectFolder);
                }
                else if(task is TexttoPDFModule texttoPDFModule)
                {
                    texttoPDFModule.Execute(projectFolder);
                }
                else if(task is WordTemplateModule wordTemplateModule)
                {
                    wordTemplateModule.Execute(projectFolder);
                }
                else if(task is MailOutModule mailOutModule)
                {
                    mailOutModule.Execute();
                }
                else if(task is ConvertModule convertModule)
                {
                    convertModule.Execute(projectFolder);
                }
                else if (task is DecryptModule decryptModule)
                {
                    decryptModule.Execute(projectFolder);
                }
                else
                {
                    throw new Exception("Module vergeten toe te voegen.");
                }
               
            }
            MessageBox.Show("Module(s) zijn succesvol uitgevoerd");
            Directory.Delete(projectFolder, true);

            // Lists leegmaken
            TaskList.Clear();
            lvExecute.Items.Clear();
        }


        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            switch (lvModules.SelectedItems[0].Text)
            {
                case "File In":
                    FileIn();
                    break;

                case "File Out":
                    FileOut();
                    break;
                case "Text replace":
                    TextReplace();
                    break;
                case "Mail Out":
                    MailOut();
                    break;
                case "Converter":
                    Convert();
                    break;
                case "Decrypt":
                    Decrypt();
                    break;
                case "Text to PDF":
                    TexttoPDF();
                    break;
                case "Word template":
                    WordTemplate();
                    break;
                default:
                    throw new InvalidOperationException("Geen geldig item gevonden");
            }

            
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            btnExecute.Enabled = false;
            btnDelete.Enabled = false;
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
        private void WordTemplate()
        {
            using(var wt = new WordtemplateForm())
            {
                DialogResult result = wt.ShowDialog();
                if(result == DialogResult.OK && wt.WordTemplateModule != null)
                {
                    TaskList.Add(wt.WordTemplateModule);
                    lvExecute.Items.Add("WordTemplate");
                }
            }
        }
        private void MailOut()
        {
            using(var mo = new MailOutForm())
            {
                DialogResult result = mo.ShowDialog();
                if(result == DialogResult.OK && mo.MailOutModule != null)
                {
                    TaskList.Add(mo.MailOutModule);
                    lvExecute.Items.Add("MailOut");
                }
            }
        }
        private void Convert()
        {
            using (var co = new ConverterForm())
            {
                DialogResult result = co.ShowDialog();
                if(result == DialogResult.OK && co.ConvertModule != null)
                {
                    TaskList.Add(co.ConvertModule);
                    lvExecute.Items.Add("Convert");
                }
            }
        }
        private void Decrypt()
        {
            using(var dec = new DecryptForm())
            {
                DialogResult result = dec.ShowDialog();
                if(result == DialogResult.OK && dec.DecryptModule != null)
                {
                    TaskList.Add(dec.DecryptModule);
                    lvExecute.Items.Add("Decrypt");
                }
            }
        }

        private void lvModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnExecute.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Listview item verwijderen uit execute list
            if(lvExecute.SelectedItems != null)
            {
                for(int i = 0; i < lvExecute.Items.Count; i++)
                {
                    if (lvExecute.Items[i].Selected)
                    {
                        lvExecute.Items[i].Remove();
                        i--;
                    }
                }
            }
        }

        private void lvExecute_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
        }

        
    }
}
