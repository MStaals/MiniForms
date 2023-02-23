namespace MiniForms.Modules.MailOut
{
    partial class MailOutForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.lblSender = new System.Windows.Forms.Label();
            this.tbSendTo = new System.Windows.Forms.TextBox();
            this.lblSendTo = new System.Windows.Forms.Label();
            this.tbCc = new System.Windows.Forms.TextBox();
            this.lblCc = new System.Windows.Forms.Label();
            this.lblBcc = new System.Windows.Forms.Label();
            this.tbBcc = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.tbMailtext = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(722, 538);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbSender
            // 
            this.tbSender.Location = new System.Drawing.Point(12, 43);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(151, 23);
            this.tbSender.TabIndex = 1;
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location = new System.Drawing.Point(12, 25);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(29, 15);
            this.lblSender.TabIndex = 2;
            this.lblSender.Text = "Van:";
            // 
            // tbSendTo
            // 
            this.tbSendTo.Location = new System.Drawing.Point(227, 25);
            this.tbSendTo.Name = "tbSendTo";
            this.tbSendTo.Size = new System.Drawing.Size(534, 23);
            this.tbSendTo.TabIndex = 3;
            // 
            // lblSendTo
            // 
            this.lblSendTo.AutoSize = true;
            this.lblSendTo.Location = new System.Drawing.Point(227, 6);
            this.lblSendTo.Name = "lblSendTo";
            this.lblSendTo.Size = new System.Drawing.Size(35, 15);
            this.lblSendTo.TabIndex = 4;
            this.lblSendTo.Text = "Naar:";
            // 
            // tbCc
            // 
            this.tbCc.Location = new System.Drawing.Point(227, 80);
            this.tbCc.Name = "tbCc";
            this.tbCc.Size = new System.Drawing.Size(534, 23);
            this.tbCc.TabIndex = 5;
            // 
            // lblCc
            // 
            this.lblCc.AutoSize = true;
            this.lblCc.Location = new System.Drawing.Point(227, 62);
            this.lblCc.Name = "lblCc";
            this.lblCc.Size = new System.Drawing.Size(24, 15);
            this.lblCc.TabIndex = 6;
            this.lblCc.Text = "Cc:";
            // 
            // lblBcc
            // 
            this.lblBcc.AutoSize = true;
            this.lblBcc.Location = new System.Drawing.Point(227, 113);
            this.lblBcc.Name = "lblBcc";
            this.lblBcc.Size = new System.Drawing.Size(29, 15);
            this.lblBcc.TabIndex = 8;
            this.lblBcc.Text = "Bcc:";
            // 
            // tbBcc
            // 
            this.tbBcc.Location = new System.Drawing.Point(227, 131);
            this.tbBcc.Name = "tbBcc";
            this.tbBcc.Size = new System.Drawing.Size(534, 23);
            this.tbBcc.TabIndex = 7;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(226, 185);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(535, 23);
            this.tbSubject.TabIndex = 9;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(228, 167);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(66, 15);
            this.lblSubject.TabIndex = 10;
            this.lblSubject.Text = "Onderwerp";
            // 
            // tbMailtext
            // 
            this.tbMailtext.Location = new System.Drawing.Point(84, 233);
            this.tbMailtext.Multiline = true;
            this.tbMailtext.Name = "tbMailtext";
            this.tbMailtext.Size = new System.Drawing.Size(636, 276);
            this.tbMailtext.TabIndex = 11;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(12, 538);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 12;
            this.btnSend.Text = "Verstuur";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // MailOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbMailtext);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.lblBcc);
            this.Controls.Add(this.tbBcc);
            this.Controls.Add(this.lblCc);
            this.Controls.Add(this.tbCc);
            this.Controls.Add(this.lblSendTo);
            this.Controls.Add(this.tbSendTo);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.tbSender);
            this.Controls.Add(this.btnClose);
            this.Name = "MailOutForm";
            this.Text = "MailOutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnClose;
        private TextBox tbSender;
        private Label lblSender;
        private TextBox tbSendTo;
        private Label lblSendTo;
        private TextBox tbCc;
        private Label lblCc;
        private Label lblBcc;
        private TextBox tbBcc;
        private TextBox tbSubject;
        private Label lblSubject;
        private TextBox tbMailtext;
        private Button btnSend;
    }
}