namespace RaiderRadarTimeLapsePhotoCapture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDrive = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Control;
            this.txtLog.Location = new System.Drawing.Point(12, 64);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(341, 220);
            this.txtLog.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saving to drive:";
            // 
            // cmbDrive
            // 
            this.cmbDrive.FormattingEnabled = true;
            this.cmbDrive.Items.AddRange(new object[] {
            "A:",
            "B:",
            "C:",
            "D:",
            "E:",
            "F:",
            "G:",
            "H:",
            "I:",
            "J:",
            "K:",
            "L:",
            "M:",
            "N:",
            "O:",
            "P:",
            "Q:",
            "R:",
            "S:",
            "T:",
            "U:",
            "V:",
            "W:",
            "X:",
            "Y:",
            "Z:"});
            this.cmbDrive.Location = new System.Drawing.Point(143, 32);
            this.cmbDrive.Name = "cmbDrive";
            this.cmbDrive.Size = new System.Drawing.Size(121, 21);
            this.cmbDrive.TabIndex = 2;
            this.cmbDrive.SelectedIndexChanged += new System.EventHandler(this.cmbDrive_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(365, 296);
            this.Controls.Add(this.cmbDrive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLog);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Raider Radar Time Lapse Photo Capture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDrive;
    }
}

