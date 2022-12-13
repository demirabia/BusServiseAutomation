namespace BusServiseAutomation
{
    partial class UserScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserScreen));
            this.btnUserDelete = new System.Windows.Forms.Button();
            this.btnUserList = new System.Windows.Forms.Button();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.gBoxStaff = new System.Windows.Forms.GroupBox();
            this.btnUserUpdate = new System.Windows.Forms.Button();
            this.btnUserAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUserYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.gBoxStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUserDelete
            // 
            this.btnUserDelete.BackColor = System.Drawing.Color.Black;
            this.btnUserDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserDelete.ForeColor = System.Drawing.Color.White;
            this.btnUserDelete.Location = new System.Drawing.Point(713, 234);
            this.btnUserDelete.Name = "btnUserDelete";
            this.btnUserDelete.Size = new System.Drawing.Size(75, 23);
            this.btnUserDelete.TabIndex = 10;
            this.btnUserDelete.Text = "Sil";
            this.btnUserDelete.UseVisualStyleBackColor = false;
            this.btnUserDelete.Click += new System.EventHandler(this.btnUserDelete_Click);
            // 
            // btnUserList
            // 
            this.btnUserList.BackColor = System.Drawing.Color.Black;
            this.btnUserList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserList.ForeColor = System.Drawing.Color.White;
            this.btnUserList.Location = new System.Drawing.Point(289, 49);
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.Size = new System.Drawing.Size(499, 23);
            this.btnUserList.TabIndex = 9;
            this.btnUserList.Text = "Listele";
            this.btnUserList.UseVisualStyleBackColor = false;
            this.btnUserList.Click += new System.EventHandler(this.btnUserList_Click);
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(289, 78);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.Size = new System.Drawing.Size(499, 150);
            this.dataGridViewUser.TabIndex = 8;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            // 
            // gBoxStaff
            // 
            this.gBoxStaff.BackColor = System.Drawing.Color.Transparent;
            this.gBoxStaff.Controls.Add(this.comboBox1);
            this.gBoxStaff.Controls.Add(this.btnUserUpdate);
            this.gBoxStaff.Controls.Add(this.btnUserAdd);
            this.gBoxStaff.Controls.Add(this.label7);
            this.gBoxStaff.Controls.Add(this.txtUserMail);
            this.gBoxStaff.Controls.Add(this.label6);
            this.gBoxStaff.Controls.Add(this.txtUserPhone);
            this.gBoxStaff.Controls.Add(this.label5);
            this.gBoxStaff.Controls.Add(this.txtUserYear);
            this.gBoxStaff.Controls.Add(this.label4);
            this.gBoxStaff.Controls.Add(this.txtUserName);
            this.gBoxStaff.Controls.Add(this.label3);
            this.gBoxStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxStaff.ForeColor = System.Drawing.Color.Black;
            this.gBoxStaff.Location = new System.Drawing.Point(12, 28);
            this.gBoxStaff.Name = "gBoxStaff";
            this.gBoxStaff.Size = new System.Drawing.Size(271, 352);
            this.gBoxStaff.TabIndex = 7;
            this.gBoxStaff.TabStop = false;
            this.gBoxStaff.Text = "Müşteriler";
            // 
            // btnUserUpdate
            // 
            this.btnUserUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUserUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUserUpdate.Location = new System.Drawing.Point(15, 314);
            this.btnUserUpdate.Name = "btnUserUpdate";
            this.btnUserUpdate.Size = new System.Drawing.Size(86, 23);
            this.btnUserUpdate.TabIndex = 14;
            this.btnUserUpdate.Text = "Güncelle";
            this.btnUserUpdate.UseVisualStyleBackColor = false;
            this.btnUserUpdate.Click += new System.EventHandler(this.btnUserUpdate_Click);
            // 
            // btnUserAdd
            // 
            this.btnUserAdd.BackColor = System.Drawing.Color.Black;
            this.btnUserAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserAdd.ForeColor = System.Drawing.Color.White;
            this.btnUserAdd.Location = new System.Drawing.Point(137, 314);
            this.btnUserAdd.Name = "btnUserAdd";
            this.btnUserAdd.Size = new System.Drawing.Size(85, 23);
            this.btnUserAdd.TabIndex = 13;
            this.btnUserAdd.Text = "Ekle";
            this.btnUserAdd.UseVisualStyleBackColor = false;
            this.btnUserAdd.Click += new System.EventHandler(this.btnUserAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bilet No :";
            // 
            // txtUserMail
            // 
            this.txtUserMail.Location = new System.Drawing.Point(122, 220);
            this.txtUserMail.Name = "txtUserMail";
            this.txtUserMail.Size = new System.Drawing.Size(121, 22);
            this.txtUserMail.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mail :";
            // 
            // txtUserPhone
            // 
            this.txtUserPhone.Location = new System.Drawing.Point(122, 156);
            this.txtUserPhone.Name = "txtUserPhone";
            this.txtUserPhone.Size = new System.Drawing.Size(121, 22);
            this.txtUserPhone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefon :";
            // 
            // txtUserYear
            // 
            this.txtUserYear.Location = new System.Drawing.Point(122, 95);
            this.txtUserYear.Name = "txtUserYear";
            this.txtUserYear.Size = new System.Drawing.Size(121, 22);
            this.txtUserYear.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Yaş :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(122, 38);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 22);
            this.txtUserName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Müşteri Adı :";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(713, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Ana Sayfa";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 274);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // UserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnUserDelete);
            this.Controls.Add(this.btnUserList);
            this.Controls.Add(this.dataGridViewUser);
            this.Controls.Add(this.gBoxStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserScreen";
            this.Load += new System.EventHandler(this.UserScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.gBoxStaff.ResumeLayout(false);
            this.gBoxStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserDelete;
        private System.Windows.Forms.Button btnUserList;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.GroupBox gBoxStaff;
        private System.Windows.Forms.Button btnUserUpdate;
        private System.Windows.Forms.Button btnUserAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUserMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUserYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}