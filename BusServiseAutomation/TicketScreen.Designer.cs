namespace BusServiseAutomation
{
    partial class TicketScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketScreen));
            this.btnTicketDelete = new System.Windows.Forms.Button();
            this.btnTicketList = new System.Windows.Forms.Button();
            this.dataGridViewTicket = new System.Windows.Forms.DataGridView();
            this.gBoxStaff = new System.Windows.Forms.GroupBox();
            this.btnTicketUpdate = new System.Windows.Forms.Button();
            this.btnTicketAdd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTicketQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTicketPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).BeginInit();
            this.gBoxStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTicketDelete
            // 
            this.btnTicketDelete.BackColor = System.Drawing.Color.Black;
            this.btnTicketDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicketDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTicketDelete.ForeColor = System.Drawing.Color.White;
            this.btnTicketDelete.Location = new System.Drawing.Point(289, 252);
            this.btnTicketDelete.Name = "btnTicketDelete";
            this.btnTicketDelete.Size = new System.Drawing.Size(75, 23);
            this.btnTicketDelete.TabIndex = 18;
            this.btnTicketDelete.Text = "Sil";
            this.btnTicketDelete.UseVisualStyleBackColor = false;
            this.btnTicketDelete.Click += new System.EventHandler(this.btnTicketDelete_Click);
            // 
            // btnTicketList
            // 
            this.btnTicketList.BackColor = System.Drawing.Color.Black;
            this.btnTicketList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicketList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTicketList.ForeColor = System.Drawing.Color.White;
            this.btnTicketList.Location = new System.Drawing.Point(289, 49);
            this.btnTicketList.Name = "btnTicketList";
            this.btnTicketList.Size = new System.Drawing.Size(499, 23);
            this.btnTicketList.TabIndex = 17;
            this.btnTicketList.Text = "Listele";
            this.btnTicketList.UseVisualStyleBackColor = false;
            this.btnTicketList.Click += new System.EventHandler(this.btnTicketList_Click);
            // 
            // dataGridViewTicket
            // 
            this.dataGridViewTicket.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridViewTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTicket.Location = new System.Drawing.Point(289, 78);
            this.dataGridViewTicket.Name = "dataGridViewTicket";
            this.dataGridViewTicket.Size = new System.Drawing.Size(499, 150);
            this.dataGridViewTicket.TabIndex = 16;
            this.dataGridViewTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTicket_CellClick);
            // 
            // gBoxStaff
            // 
            this.gBoxStaff.BackColor = System.Drawing.Color.Transparent;
            this.gBoxStaff.Controls.Add(this.comboBox1);
            this.gBoxStaff.Controls.Add(this.txtTotal);
            this.gBoxStaff.Controls.Add(this.label1);
            this.gBoxStaff.Controls.Add(this.btnTicketUpdate);
            this.gBoxStaff.Controls.Add(this.btnTicketAdd);
            this.gBoxStaff.Controls.Add(this.label5);
            this.gBoxStaff.Controls.Add(this.txtTicketQty);
            this.gBoxStaff.Controls.Add(this.label4);
            this.gBoxStaff.Controls.Add(this.txtTicketPrice);
            this.gBoxStaff.Controls.Add(this.label3);
            this.gBoxStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gBoxStaff.Location = new System.Drawing.Point(12, 49);
            this.gBoxStaff.Name = "gBoxStaff";
            this.gBoxStaff.Size = new System.Drawing.Size(255, 352);
            this.gBoxStaff.TabIndex = 15;
            this.gBoxStaff.TabStop = false;
            this.gBoxStaff.Text = "Bilet Al";
            // 
            // btnTicketUpdate
            // 
            this.btnTicketUpdate.BackColor = System.Drawing.Color.Black;
            this.btnTicketUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicketUpdate.ForeColor = System.Drawing.Color.White;
            this.btnTicketUpdate.Location = new System.Drawing.Point(15, 314);
            this.btnTicketUpdate.Name = "btnTicketUpdate";
            this.btnTicketUpdate.Size = new System.Drawing.Size(86, 23);
            this.btnTicketUpdate.TabIndex = 14;
            this.btnTicketUpdate.Text = "Güncelle";
            this.btnTicketUpdate.UseVisualStyleBackColor = false;
            this.btnTicketUpdate.Click += new System.EventHandler(this.btnTicketUpdate_Click);
            // 
            // btnTicketAdd
            // 
            this.btnTicketAdd.BackColor = System.Drawing.Color.Black;
            this.btnTicketAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTicketAdd.ForeColor = System.Drawing.Color.White;
            this.btnTicketAdd.Location = new System.Drawing.Point(137, 314);
            this.btnTicketAdd.Name = "btnTicketAdd";
            this.btnTicketAdd.Size = new System.Drawing.Size(85, 23);
            this.btnTicketAdd.TabIndex = 13;
            this.btnTicketAdd.Text = "Ekle";
            this.btnTicketAdd.UseVisualStyleBackColor = false;
            this.btnTicketAdd.Click += new System.EventHandler(this.btnTicketAdd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Otobüs No :";
            // 
            // txtTicketQty
            // 
            this.txtTicketQty.Location = new System.Drawing.Point(122, 95);
            this.txtTicketQty.Name = "txtTicketQty";
            this.txtTicketQty.Size = new System.Drawing.Size(121, 22);
            this.txtTicketQty.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bilet Adet :";
            // 
            // txtTicketPrice
            // 
            this.txtTicketPrice.Location = new System.Drawing.Point(122, 38);
            this.txtTicketPrice.Name = "txtTicketPrice";
            this.txtTicketPrice.Size = new System.Drawing.Size(121, 22);
            this.txtTicketPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bilet Fiyat :";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(122, 203);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(121, 22);
            this.txtTotal.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tutar :";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Black;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(713, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Ana Sayfa";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // TicketScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnTicketDelete);
            this.Controls.Add(this.btnTicketList);
            this.Controls.Add(this.dataGridViewTicket);
            this.Controls.Add(this.gBoxStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TicketScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketScreen";
            this.Load += new System.EventHandler(this.TicketScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).EndInit();
            this.gBoxStaff.ResumeLayout(false);
            this.gBoxStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTicketDelete;
        private System.Windows.Forms.Button btnTicketList;
        private System.Windows.Forms.DataGridView dataGridViewTicket;
        private System.Windows.Forms.GroupBox gBoxStaff;
        private System.Windows.Forms.Button btnTicketUpdate;
        private System.Windows.Forms.Button btnTicketAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTicketQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTicketPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}