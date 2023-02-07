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
            this.btnExecute = new System.Windows.Forms.Button();
            this.lbModules = new System.Windows.Forms.ListBox();
            this.lbExecute = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(661, 392);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(94, 29);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // lbModules
            // 
            this.lbModules.FormattingEnabled = true;
            this.lbModules.ItemHeight = 20;
            this.lbModules.Items.AddRange(new object[] {
            "Folder-In",
            "Folder-Out",
            "Text Replace",
            "MailOut",
            "Convert",
            "Decode",
            "ToPDF",
            "WordTemplate"});
            this.lbModules.Location = new System.Drawing.Point(23, 49);
            this.lbModules.Name = "lbModules";
            this.lbModules.Size = new System.Drawing.Size(150, 144);
            this.lbModules.TabIndex = 3;
            this.lbModules.DoubleClick += new System.EventHandler(this.lbModules_DoubleClick);
            // 
            // lbExecute
            // 
            this.lbExecute.FormattingEnabled = true;
            this.lbExecute.ItemHeight = 20;
            this.lbExecute.Location = new System.Drawing.Point(468, 49);
            this.lbExecute.Name = "lbExecute";
            this.lbExecute.Size = new System.Drawing.Size(150, 104);
            this.lbExecute.TabIndex = 4;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbExecute);
            this.Controls.Add(this.lbModules);
            this.Controls.Add(this.btnExecute);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnExecute;
        private ListBox lbModules;
        private ListBox lbExecute;
    }
}