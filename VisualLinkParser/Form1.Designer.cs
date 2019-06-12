namespace VisualLinkParser
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
            this.LblAddress = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.LblDisplay = new System.Windows.Forms.Label();
            this.TxtDisplay = new System.Windows.Forms.TextBox();
            this.BtnRun = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Location = new System.Drawing.Point(13, 45);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(48, 13);
            this.LblAddress.TabIndex = 0;
            this.LblAddress.Text = "Address:";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(68, 45);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(304, 20);
            this.TxtAddress.TabIndex = 1;
            // 
            // LblDisplay
            // 
            this.LblDisplay.AutoSize = true;
            this.LblDisplay.Location = new System.Drawing.Point(17, 75);
            this.LblDisplay.Name = "LblDisplay";
            this.LblDisplay.Size = new System.Drawing.Size(45, 13);
            this.LblDisplay.TabIndex = 2;
            this.LblDisplay.Text = "Results:";
            // 
            // TxtDisplay
            // 
            this.TxtDisplay.Location = new System.Drawing.Point(68, 72);
            this.TxtDisplay.Multiline = true;
            this.TxtDisplay.Name = "TxtDisplay";
            this.TxtDisplay.ReadOnly = true;
            this.TxtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDisplay.Size = new System.Drawing.Size(304, 131);
            this.TxtDisplay.TabIndex = 3;
            // 
            // BtnRun
            // 
            this.BtnRun.Location = new System.Drawing.Point(68, 210);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(75, 23);
            this.BtnRun.TabIndex = 4;
            this.BtnRun.Text = "Run";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(150, 209);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 23);
            this.BtnClear.TabIndex = 5;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(296, 209);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 297);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.TxtDisplay);
            this.Controls.Add(this.LblDisplay);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.LblAddress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label LblDisplay;
        private System.Windows.Forms.TextBox TxtDisplay;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
    }
}

