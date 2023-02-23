namespace MiniForms.Modules.TextReplace
{
    partial class TextReplaceForm
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
            this.tbOld = new System.Windows.Forms.TextBox();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.lblOld = new System.Windows.Forms.Label();
            this.lblNieuw = new System.Windows.Forms.Label();
            this.btnReWrite = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOld
            // 
            this.tbOld.Location = new System.Drawing.Point(223, 40);
            this.tbOld.Name = "tbOld";
            this.tbOld.Size = new System.Drawing.Size(176, 23);
            this.tbOld.TabIndex = 0;
            // 
            // tbNew
            // 
            this.tbNew.Location = new System.Drawing.Point(223, 99);
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(181, 23);
            this.tbNew.TabIndex = 1;
            // 
            // lblOld
            // 
            this.lblOld.AutoSize = true;
            this.lblOld.Location = new System.Drawing.Point(223, 9);
            this.lblOld.Name = "lblOld";
            this.lblOld.Size = new System.Drawing.Size(67, 15);
            this.lblOld.TabIndex = 2;
            this.lblOld.Text = "Oud woord";
            // 
            // lblNieuw
            // 
            this.lblNieuw.AutoSize = true;
            this.lblNieuw.Location = new System.Drawing.Point(223, 81);
            this.lblNieuw.Name = "lblNieuw";
            this.lblNieuw.Size = new System.Drawing.Size(78, 15);
            this.lblNieuw.TabIndex = 3;
            this.lblNieuw.Text = "Nieuw woord";
            // 
            // btnReWrite
            // 
            this.btnReWrite.Location = new System.Drawing.Point(223, 138);
            this.btnReWrite.Name = "btnReWrite";
            this.btnReWrite.Size = new System.Drawing.Size(75, 23);
            this.btnReWrite.TabIndex = 4;
            this.btnReWrite.Text = "Re-write";
            this.btnReWrite.UseVisualStyleBackColor = true;
            this.btnReWrite.Click += new System.EventHandler(this.btnReWrite_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(23, 73);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(100, 23);
            this.tbPath.TabIndex = 5;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(23, 40);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(31, 15);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "Path";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(348, 138);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TextReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 173);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btnReWrite);
            this.Controls.Add(this.lblNieuw);
            this.Controls.Add(this.lblOld);
            this.Controls.Add(this.tbNew);
            this.Controls.Add(this.tbOld);
            this.Name = "TextReplaceForm";
            this.Text = "TextReplaceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbOld;
        private TextBox tbNew;
        private Label lblOld;
        private Label lblNieuw;
        private Button btnReWrite;
        private TextBox tbPath;
        private Label lblPath;
        private Button btnClose;
    }
}