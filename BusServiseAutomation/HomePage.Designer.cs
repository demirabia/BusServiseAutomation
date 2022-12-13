namespace BusServiseAutomation
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnBus = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.BtUser = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBus
            // 
            this.btnBus.BackColor = System.Drawing.Color.Black;
            this.btnBus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBus.ForeColor = System.Drawing.Color.White;
            this.btnBus.Location = new System.Drawing.Point(156, 132);
            this.btnBus.Name = "btnBus";
            this.btnBus.Size = new System.Drawing.Size(174, 45);
            this.btnBus.TabIndex = 0;
            this.btnBus.Text = "OTOBÜSLER";
            this.btnBus.UseVisualStyleBackColor = false;
            this.btnBus.Click += new System.EventHandler(this.btnBus_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.Black;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTicket.ForeColor = System.Drawing.Color.White;
            this.btnTicket.Location = new System.Drawing.Point(481, 132);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(174, 45);
            this.btnTicket.TabIndex = 1;
            this.btnTicket.Text = "BİLET AL";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // BtUser
            // 
            this.BtUser.BackColor = System.Drawing.Color.Black;
            this.BtUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtUser.ForeColor = System.Drawing.Color.White;
            this.BtUser.Location = new System.Drawing.Point(320, 229);
            this.BtUser.Name = "BtUser";
            this.BtUser.Size = new System.Drawing.Size(174, 45);
            this.BtUser.TabIndex = 2;
            this.BtUser.Text = "MÜŞTERİLER";
            this.BtUser.UseVisualStyleBackColor = false;
            this.BtUser.Click += new System.EventHandler(this.BtUser_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(115, 415);
            this.btnNext.Name = "btnNext";
            this.btnNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 20;
            this.btnNext.Text = "Geri";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Black;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(518, 393);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(174, 45);
            this.btnReport.TabIndex = 21;
            this.btnReport.Text = "RAPORLAR";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.BtUser);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.btnBus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBus;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button BtUser;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReport;
    }
}