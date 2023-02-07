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
        public HomeForm()
        {
            InitializeComponent();
        }

        private void rtbModule_DoubleClick(object sender, EventArgs e)
        {
            

            if (rtbModule.SelectedText == "FolderIn")
            {

                OpenFileDialog dlg = new OpenFileDialog();
                dlg.ShowDialog();
            }
            else if(rtbModule.SelectedText == "FolderOut")
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.ShowDialog();
            }
            else if(rtbModule.SelectedText == "")
            {

            }
            else
            {

            }
        }
    }
}
