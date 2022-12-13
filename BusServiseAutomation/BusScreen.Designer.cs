namespace BusServiseAutomation
{
    partial class BusScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusScreen));
            this.btnBusDelete = new System.Windows.Forms.Button();
            this.btnBusList = new System.Windows.Forms.Button();
            this.dataGridViewBus = new System.Windows.Forms.DataGridView();
            this.gBoxStaff = new System.Windows.Forms.GroupBox();
            this.btnBusUpdate = new System.Windows.Forms.Button();
            this.btnBusAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBusDestination = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBusLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusPlate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBus)).BeginInit();
            this.gBoxStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBusDelete
            // 
            this.btnBusDelete.BackColor = System.Drawing.Color.Black;
            this.btnBusDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBusDelete.ForeColor = System.Drawing.Color.White;
            this.btnBusDelete.Location = new System.Drawing.Point(289, 252);
            this.btnBusDelete.Name = "btnBusDelete";
            this.btnBusDelete.Size = new System.Drawing.Size(75, 23);
            this.btnBusDelete.TabIndex = 14;
            this.btnBusDelete.Text = "Sil";
            this.btnBusDelete.UseVisualStyleBackColor = false;
            this.btnBusDelete.Click += new System.EventHandler(this.btnBusDelete_Click);
            // 
            // btnBusList
            // 
            this.btnBusList.BackColor = System.Drawing.Color.Black;
            this.btnBusList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBusList.ForeColor = System.Drawing.Color.White;
            this.btnBusList.Location = new System.Drawing.Point(289, 49);
            this.btnBusList.Name = "btnBusList";
            this.btnBusList.Size = new System.Drawing.Size(499, 23);
            this.btnBusList.TabIndex = 13;
            this.btnBusList.Text = "Listele";
            this.btnBusList.UseVisualStyleBackColor = false;
            this.btnBusList.Click += new System.EventHandler(this.btnBusList_Click);
            // 
            // dataGridViewBus
            // 
            this.dataGridViewBus.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.dataGridViewBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBus.Location = new System.Drawing.Point(289, 78);
            this.dataGridViewBus.Name = "dataGridViewBus";
            this.dataGridViewBus.Size = new System.Drawing.Size(499, 150);
            this.dataGridViewBus.TabIndex = 12;
            this.dataGridViewBus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBus_CellClick);
            // 
            // gBoxStaff
            // 
            this.gBoxStaff.BackColor = System.Drawing.Color.Transparent;
            this.gBoxStaff.Controls.Add(this.comboBox1);
            this.gBoxStaff.Controls.Add(this.btnBusUpdate);
            this.gBoxStaff.Controls.Add(this.btnBusAdd);
            this.gBoxStaff.Controls.Add(this.label7);
            this.gBoxStaff.Controls.Add(this.txtBusDestination);
            this.gBoxStaff.Controls.Add(this.label6);
            this.gBoxStaff.Controls.Add(this.txtBusLocation);
            this.gBoxStaff.Controls.Add(this.label5);
            this.gBoxStaff.Controls.Add(this.txtBusPlate);
            this.gBoxStaff.Controls.Add(this.label4);
            this.gBoxStaff.Controls.Add(this.txtBusName);
            this.gBoxStaff.Controls.Add(this.label3);
            this.gBoxStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxStaff.Location = new System.Drawing.Point(12, 49);
            this.gBoxStaff.Name = "gBoxStaff";
            this.gBoxStaff.Size = new System.Drawing.Size(255, 352);
            this.gBoxStaff.TabIndex = 11;
            this.gBoxStaff.TabStop = false;
            this.gBoxStaff.Text = "Otobüsler";
            // 
            // btnBusUpdate
            // 
            this.btnBusUpdate.BackColor = System.Drawing.Color.Black;
            this.btnBusUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusUpdate.ForeColor = System.Drawing.Color.White;
            this.btnBusUpdate.Location = new System.Drawing.Point(15, 314);
            this.btnBusUpdate.Name = "btnBusUpdate";
            this.btnBusUpdate.Size = new System.Drawing.Size(86, 23);
            this.btnBusUpdate.TabIndex = 14;
            this.btnBusUpdate.Text = "Güncelle";
            this.btnBusUpdate.UseVisualStyleBackColor = false;
            this.btnBusUpdate.Click += new System.EventHandler(this.btnBusUpdate_Click);
            // 
            // btnBusAdd
            // 
            this.btnBusAdd.BackColor = System.Drawing.Color.Black;
            this.btnBusAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusAdd.ForeColor = System.Drawing.Color.White;
            this.btnBusAdd.Location = new System.Drawing.Point(137, 314);
            this.btnBusAdd.Name = "btnBusAdd";
            this.btnBusAdd.Size = new System.Drawing.Size(85, 23);
            this.btnBusAdd.TabIndex = 13;
            this.btnBusAdd.Text = "Ekle";
            this.btnBusAdd.UseVisualStyleBackColor = false;
            this.btnBusAdd.Click += new System.EventHandler(this.btnBusAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Personel No :";
            // 
            // txtBusDestination
            // 
            this.txtBusDestination.Location = new System.Drawing.Point(122, 220);
            this.txtBusDestination.Name = "txtBusDestination";
            this.txtBusDestination.Size = new System.Drawing.Size(121, 22);
            this.txtBusDestination.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Varış Yeri :";
            // 
            // txtBusLocation
            // 
            this.txtBusLocation.Location = new System.Drawing.Point(122, 156);
            this.txtBusLocation.Name = "txtBusLocation";
            this.txtBusLocation.Size = new System.Drawing.Size(121, 22);
            this.txtBusLocation.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kalkış Yeri :";
            // 
            // txtBusPlate
            // 
            this.txtBusPlate.Location = new System.Drawing.Point(122, 95);
            this.txtBusPlate.Name = "txtBusPlate";
            this.txtBusPlate.Size = new System.Drawing.Size(121, 22);
            this.txtBusPlate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Araç Plakası :";
            // 
            // txtBusName
            // 
            this.txtBusName.Location = new System.Drawing.Point(122, 38);
            this.txtBusName.Name = "txtBusName";
            this.txtBusName.Size = new System.Drawing.Size(121, 22);
            this.txtBusName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Firma Adı :";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(713, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Ana Sayfa";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // BusScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBusDelete);
            this.Controls.Add(this.btnBusList);
            this.Controls.Add(this.dataGridViewBus);
            this.Controls.Add(this.gBoxStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BusScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BusScreen";
            this.Load += new System.EventHandler(this.BusScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBus)).EndInit();
            this.gBoxStaff.ResumeLayout(false);
            this.gBoxStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBusDelete;
        private System.Windows.Forms.Button btnBusList;
        private System.Windows.Forms.DataGridView dataGridViewBus;
        private System.Windows.Forms.GroupBox gBoxStaff;
        private System.Windows.Forms.Button btnBusUpdate;
        private System.Windows.Forms.Button btnBusAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBusDestination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBusLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusPlate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBusName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}