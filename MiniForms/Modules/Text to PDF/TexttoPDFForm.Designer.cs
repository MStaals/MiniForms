﻿namespace MiniForms.Modules.Text_to_PDF
{
    partial class TexttoPDFForm
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
            this.btnConverttoPDF = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConverttoPDF
            // 
            this.btnConverttoPDF.Location = new System.Drawing.Point(78, 112);
            this.btnConverttoPDF.Name = "btnConverttoPDF";
            this.btnConverttoPDF.Size = new System.Drawing.Size(75, 23);
            this.btnConverttoPDF.TabIndex = 0;
            this.btnConverttoPDF.Text = "Convert";
            this.btnConverttoPDF.UseVisualStyleBackColor = true;
            this.btnConverttoPDF.Click += new System.EventHandler(this.btnConverttoPDF_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(276, 112);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TexttoPDFForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 188);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConverttoPDF);
            this.Name = "TexttoPDFForm";
            this.Text = "TexttoPDFForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnConverttoPDF;
        private Button btnClose;
    }
}