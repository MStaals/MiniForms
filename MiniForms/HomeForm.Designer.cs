namespace MiniForms
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("File In");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("File Out");
            this.btnExecute = new System.Windows.Forms.Button();
            this.lbExecute = new System.Windows.Forms.ListBox();
            this.lvModules = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(578, 294);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(82, 22);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lbExecute
            // 
            this.lbExecute.FormattingEnabled = true;
            this.lbExecute.ItemHeight = 15;
            this.lbExecute.Location = new System.Drawing.Point(418, 37);
            this.lbExecute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbExecute.Name = "lbExecute";
            this.lbExecute.Size = new System.Drawing.Size(132, 109);
            this.lbExecute.TabIndex = 4;
            // 
            // lvModules
            // 
            this.lvModules.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvModules.Location = new System.Drawing.Point(46, 38);
            this.lvModules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvModules.Name = "lvModules";
            this.lvModules.Size = new System.Drawing.Size(180, 117);
            this.lvModules.TabIndex = 5;
            this.lvModules.UseCompatibleStateImageBehavior = false;
            this.lvModules.View = System.Windows.Forms.View.SmallIcon;
            this.lvModules.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 332);
            this.Controls.Add(this.lvModules);
            this.Controls.Add(this.lbExecute);
            this.Controls.Add(this.btnExecute);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnExecute;
        private ListBox lbExecute;
        private ListView lvModules;
    }
}