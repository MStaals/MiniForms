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
            this.rtbModule = new System.Windows.Forms.RichTextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbModule
            // 
            this.rtbModule.Location = new System.Drawing.Point(12, 12);
            this.rtbModule.Name = "rtbModule";
            this.rtbModule.Size = new System.Drawing.Size(188, 288);
            this.rtbModule.TabIndex = 0;
            this.rtbModule.Text = "FolderIn\nFolderout\nTextReplace\nMailOut\nConvert\nDecode\nToPDF\nWordTemplate";
            this.rtbModule.DoubleClick += new System.EventHandler(this.rtbModule_DoubleClick);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(661, 392);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(94, 29);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(399, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(209, 288);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.rtbModule);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtbModule;
        private Button btnExecute;
        private RichTextBox richTextBox1;
    }
}