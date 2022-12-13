namespace BusServiseAutomation
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gBoxStaffLogin = new System.Windows.Forms.GroupBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtStaffPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.gBoxStaff = new System.Windows.Forms.GroupBox();
            this.txtStaffAddName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPasswordAdd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSatffPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStaffMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.btnStaffUpdate = new System.Windows.Forms.Button();
            this.dataGridViewStaff = new System.Windows.Forms.DataGridView();
            this.btnStaffList = new System.Windows.Forms.Button();
            this.btnStaffDelete = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gBoxStaffLogin.SuspendLayout();
            this.gBoxStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifte :";
            // 
            // gBoxStaffLogin
            // 
            this.gBoxStaffLogin.Controls.Add(this.btnLogin);
            this.gBoxStaffLogin.Controls.Add(this.txtStaffPassword);
            this.gBoxStaffLogin.Controls.Add(this.txtStaffName);
            this.gBoxStaffLogin.Controls.Add(this.label1);
            this.gBoxStaffLogin.Controls.Add(this.label2);
            this.gBoxStaffLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxStaffLogin.Location = new System.Drawing.Point(12, 89);
            this.gBoxStaffLogin.Name = "gBoxStaffLogin";
            this.gBoxStaffLogin.Size = new System.Drawing.Size(235, 176);
            this.gBoxStaffLogin.TabIndex = 2;
            this.gBoxStaffLogin.TabStop = false;
            this.gBoxStaffLogin.Text = "Personel Giriş";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(116, 52);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(100, 22);
            this.txtStaffName.TabIndex = 2;
            // 
            // txtStaffPassword
            // 
            this.txtStaffPassword.Location = new System.Drawing.Point(116, 103);
            this.txtStaffPassword.Name = "txtStaffPassword";
            this.txtStaffPassword.Size = new System.Drawing.Size(100, 22);
            this.txtStaffPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(138, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(78, 23);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // gBoxStaff
            // 
            this.gBoxStaff.BackColor = System.Drawing.Color.Transparent;
            this.gBoxStaff.Controls.Add(this.comboBox1);
            this.gBoxStaff.Controls.Add(this.btnStaffUpdate);
            this.gBoxStaff.Controls.Add(this.btnStaffAdd);
            this.gBoxStaff.Controls.Add(this.label7);
            this.gBoxStaff.Controls.Add(this.txtStaffMail);
            this.gBoxStaff.Controls.Add(this.label6);
            this.gBoxStaff.Controls.Add(this.txtSatffPhone);
            this.gBoxStaff.Controls.Add(this.label5);
            this.gBoxStaff.Controls.Add(this.txtPasswordAdd);
            this.gBoxStaff.Controls.Add(this.label4);
            this.gBoxStaff.Controls.Add(this.txtStaffAddName);
            this.gBoxStaff.Controls.Add(this.label3);
            this.gBoxStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxStaff.ForeColor = System.Drawing.Color.Black;
            this.gBoxStaff.Location = new System.Drawing.Point(189, 27);
            this.gBoxStaff.Name = "gBoxStaff";
            this.gBoxStaff.Size = new System.Drawing.Size(255, 352);
            this.gBoxStaff.TabIndex = 3;
            this.gBoxStaff.TabStop = false;
            this.gBoxStaff.Text = "Personel Ekle";
            // 
            // txtStaffAddName
            // 
            this.txtStaffAddName.Location = new System.Drawing.Point(122, 38);
            this.txtStaffAddName.Name = "txtStaffAddName";
            this.txtStaffAddName.Size = new System.Drawing.Size(121, 22);
            this.txtStaffAddName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Personel Adı :";
            // 
            // txtPasswordAdd
            // 
            this.txtPasswordAdd.Location = new System.Drawing.Point(122, 95);
            this.txtPasswordAdd.Name = "txtPasswordAdd";
            this.txtPasswordAdd.Size = new System.Drawing.Size(121, 22);
            this.txtPasswordAdd.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Şifre :";
            // 
            // txtSatffPhone
            // 
            this.txtSatffPhone.Location = new System.Drawing.Point(122, 156);
            this.txtSatffPhone.Name = "txtSatffPhone";
            this.txtSatffPhone.Size = new System.Drawing.Size(121, 22);
            this.txtSatffPhone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefon :";
            // 
            // txtStaffMail
            // 
            this.txtStaffMail.Location = new System.Drawing.Point(122, 220);
            this.txtStaffMail.Name = "txtStaffMail";
            this.txtStaffMail.Size = new System.Drawing.Size(121, 22);
            this.txtStaffMail.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mail :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(12, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Müşteri No :";
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.BackColor = System.Drawing.Color.Black;
            this.btnStaffAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStaffAdd.ForeColor = System.Drawing.Color.White;
            this.btnStaffAdd.Location = new System.Drawing.Point(137, 314);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(85, 23);
            this.btnStaffAdd.TabIndex = 13;
            this.btnStaffAdd.Text = "Ekle";
            this.btnStaffAdd.UseVisualStyleBackColor = false;
            this.btnStaffAdd.Click += new System.EventHandler(this.btnStaffAdd_Click);
            // 
            // btnStaffUpdate
            // 
            this.btnStaffUpdate.BackColor = System.Drawing.Color.Black;
            this.btnStaffUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStaffUpdate.ForeColor = System.Drawing.Color.White;
            this.btnStaffUpdate.Location = new System.Drawing.Point(15, 314);
            this.btnStaffUpdate.Name = "btnStaffUpdate";
            this.btnStaffUpdate.Size = new System.Drawing.Size(86, 23);
            this.btnStaffUpdate.TabIndex = 14;
            this.btnStaffUpdate.Text = "Güncelle";
            this.btnStaffUpdate.UseVisualStyleBackColor = false;
            this.btnStaffUpdate.Click += new System.EventHandler(this.btnStaffUpdate_Click);
            // 
            // dataGridViewStaff
            // 
            this.dataGridViewStaff.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStaff.Location = new System.Drawing.Point(289, 65);
            this.dataGridViewStaff.Name = "dataGridViewStaff";
            this.dataGridViewStaff.Size = new System.Drawing.Size(499, 150);
            this.dataGridViewStaff.TabIndex = 4;
            this.dataGridViewStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStaff_CellClick);
            // 
            // btnStaffList
            // 
            this.btnStaffList.BackColor = System.Drawing.Color.Black;
            this.btnStaffList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStaffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStaffList.ForeColor = System.Drawing.Color.White;
            this.btnStaffList.Location = new System.Drawing.Point(289, 39);
            this.btnStaffList.Name = "btnStaffList";
            this.btnStaffList.Size = new System.Drawing.Size(499, 23);
            this.btnStaffList.TabIndex = 5;
            this.btnStaffList.Text = "Listele";
            this.btnStaffList.UseVisualStyleBackColor = false;
            this.btnStaffList.Click += new System.EventHandler(this.btnStaffList_Click);
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.BackColor = System.Drawing.Color.Black;
            this.btnStaffDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStaffDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStaffDelete.ForeColor = System.Drawing.Color.White;
            this.btnStaffDelete.Location = new System.Drawing.Point(713, 221);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(75, 23);
            this.btnStaffDelete.TabIndex = 6;
            this.btnStaffDelete.Text = "Sil";
            this.btnStaffDelete.UseVisualStyleBackColor = false;
            this.btnStaffDelete.Click += new System.EventHandler(this.btnStaffDelete_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(713, 400);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "İleri";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 272);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStaffDelete);
            this.Controls.Add(this.btnStaffList);
            this.Controls.Add(this.dataGridViewStaff);
            this.Controls.Add(this.gBoxStaff);
            this.Controls.Add(this.gBoxStaffLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxStaffLogin.ResumeLayout(false);
            this.gBoxStaffLogin.PerformLayout();
            this.gBoxStaff.ResumeLayout(false);
            this.gBoxStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBoxStaffLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtStaffPassword;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.GroupBox gBoxStaff;
        private System.Windows.Forms.Button btnStaffUpdate;
        private System.Windows.Forms.Button btnStaffAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStaffMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSatffPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPasswordAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStaffAddName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewStaff;
        private System.Windows.Forms.Button btnStaffList;
        private System.Windows.Forms.Button btnStaffDelete;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

