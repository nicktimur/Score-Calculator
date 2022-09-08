namespace Not_Hesaplayıcı
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CevapAnahtarı = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.isim = new System.Windows.Forms.TextBox();
            this.Cevaplar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AltBilgi = new System.Windows.Forms.TextBox();
            this.UstBilgi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ort = new System.Windows.Forms.TextBox();
            this.isim2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TRback = new System.Windows.Forms.RichTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ENback = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(433, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Adı Soyadı";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cevapları";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Sınavı\'nın Cevap Anahtarı";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 151;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Puanı";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(98, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sınav Bilgileri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cevap Anahtarı:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CevapAnahtarı
            // 
            this.CevapAnahtarı.Location = new System.Drawing.Point(107, 76);
            this.CevapAnahtarı.Name = "CevapAnahtarı";
            this.CevapAnahtarı.Size = new System.Drawing.Size(302, 20);
            this.CevapAnahtarı.TabIndex = 5;
            this.CevapAnahtarı.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.CevapAnahtarı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CevapAnahtarı_KeyPress);
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(36, 262);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(86, 23);
            this.Insert.TabIndex = 6;
            this.Insert.Text = "Öğrenci Ekle";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(85, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "Öğrenci Bilgileri";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(323, 262);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(86, 23);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Öğrenci Sil";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(171, 262);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(94, 23);
            this.Update.TabIndex = 9;
            this.Update.Text = "Cevabı Düzenle";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(104, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adı Soyadı:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // isim
            // 
            this.isim.Location = new System.Drawing.Point(171, 182);
            this.isim.Name = "isim";
            this.isim.Size = new System.Drawing.Size(155, 20);
            this.isim.TabIndex = 11;
            this.isim.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Cevaplar
            // 
            this.Cevaplar.Location = new System.Drawing.Point(171, 220);
            this.Cevaplar.Name = "Cevaplar";
            this.Cevaplar.Size = new System.Drawing.Size(139, 20);
            this.Cevaplar.TabIndex = 13;
            this.Cevaplar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.Cevaplar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cevaplar_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(111, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cevapları:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AltBilgi
            // 
            this.AltBilgi.Location = new System.Drawing.Point(306, 220);
            this.AltBilgi.Name = "AltBilgi";
            this.AltBilgi.ReadOnly = true;
            this.AltBilgi.Size = new System.Drawing.Size(20, 20);
            this.AltBilgi.TabIndex = 14;
            // 
            // UstBilgi
            // 
            this.UstBilgi.Location = new System.Drawing.Point(406, 76);
            this.UstBilgi.Name = "UstBilgi";
            this.UstBilgi.ReadOnly = true;
            this.UstBilgi.Size = new System.Drawing.Size(20, 20);
            this.UstBilgi.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Öğrencilerin Ortalaması:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(21, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "En yüksek notu alan kişi/ kişiler:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ort
            // 
            this.ort.BackColor = System.Drawing.Color.White;
            this.ort.Location = new System.Drawing.Point(155, 375);
            this.ort.Name = "ort";
            this.ort.ReadOnly = true;
            this.ort.Size = new System.Drawing.Size(76, 20);
            this.ort.TabIndex = 18;
            // 
            // isim2
            // 
            this.isim2.BackColor = System.Drawing.Color.White;
            this.isim2.Location = new System.Drawing.Point(197, 409);
            this.isim2.Name = "isim2";
            this.isim2.ReadOnly = true;
            this.isim2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.isim2.Size = new System.Drawing.Size(230, 20);
            this.isim2.TabIndex = 19;
            this.isim2.TextChanged += new System.EventHandler(this.isim2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(136, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 50);
            this.label8.TabIndex = 20;
            this.label8.Text = "Detaylar";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TRback
            // 
            this.TRback.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.TRback.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TRback.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TRback.Location = new System.Drawing.Point(12, 12);
            this.TRback.Name = "TRback";
            this.TRback.ReadOnly = true;
            this.TRback.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TRback.Size = new System.Drawing.Size(25, 30);
            this.TRback.TabIndex = 24;
            this.TRback.Text = "";
            this.TRback.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // ENback
            // 
            this.ENback.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ENback.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ENback.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ENback.Location = new System.Drawing.Point(43, 12);
            this.ENback.Name = "ENback";
            this.ENback.ReadOnly = true;
            this.ENback.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ENback.Size = new System.Drawing.Size(25, 30);
            this.ENback.TabIndex = 27;
            this.ENback.Text = "";
            this.ENback.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(43, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Form1
            // 
            this.AcceptButton = this.Insert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ENback);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.TRback);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.isim2);
            this.Controls.Add(this.ort);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UstBilgi);
            this.Controls.Add(this.AltBilgi);
            this.Controls.Add(this.Cevaplar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.isim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.CevapAnahtarı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Not Hesaplayıcı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CevapAnahtarı;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox isim;
        private System.Windows.Forms.TextBox Cevaplar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AltBilgi;
        private System.Windows.Forms.TextBox UstBilgi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ort;
        private System.Windows.Forms.TextBox isim2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.RichTextBox TRback;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RichTextBox ENback;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

