namespace TestLogAnalyzer
{
    partial class Form1
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
            this.PrismaErrLabel = new System.Windows.Forms.Label();
            this.CommMgrErrLabel = new System.Windows.Forms.Label();
            this.RetryButton = new System.Windows.Forms.Button();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrismaErrLabel
            // 
            this.PrismaErrLabel.AutoSize = true;
            this.PrismaErrLabel.Location = new System.Drawing.Point(200, 71);
            this.PrismaErrLabel.Name = "PrismaErrLabel";
            this.PrismaErrLabel.Size = new System.Drawing.Size(84, 13);
            this.PrismaErrLabel.TabIndex = 0;
            this.PrismaErrLabel.Text = "Prisma Error Log";
            this.PrismaErrLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CommMgrErrLabel
            // 
            this.CommMgrErrLabel.AutoSize = true;
            this.CommMgrErrLabel.Location = new System.Drawing.Point(192, 102);
            this.CommMgrErrLabel.Name = "CommMgrErrLabel";
            this.CommMgrErrLabel.Size = new System.Drawing.Size(100, 13);
            this.CommMgrErrLabel.TabIndex = 1;
            this.CommMgrErrLabel.Text = "CommMgr Error Log";
            this.CommMgrErrLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // RetryButton
            // 
            this.RetryButton.Location = new System.Drawing.Point(385, 128);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(87, 26);
            this.RetryButton.TabIndex = 3;
            this.RetryButton.Text = "Retry";
            this.RetryButton.UseVisualStyleBackColor = true;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(385, 160);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(87, 26);
            this.ContinueButton.TabIndex = 4;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 189);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(484, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.CommMgrErrLabel);
            this.Controls.Add(this.PrismaErrLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrismaErrLabel;
        private System.Windows.Forms.Label CommMgrErrLabel;
        private System.Windows.Forms.Button RetryButton;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

