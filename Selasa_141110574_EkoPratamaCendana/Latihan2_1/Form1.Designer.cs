namespace Latihan2_1
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
            this.Kalender = new System.Windows.Forms.MonthCalendar();
            this.Tanggal = new System.Windows.Forms.NumericUpDown();
            this.Bulan = new System.Windows.Forms.DomainUpDown();
            this.Tambah = new System.Windows.Forms.Button();
            this.Hapus = new System.Windows.Forms.Button();
            this.Lahir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Tanggal)).BeginInit();
            this.SuspendLayout();
            // 
            // Kalender
            // 
            this.Kalender.Location = new System.Drawing.Point(18, 18);
            this.Kalender.Name = "Kalender";
            this.Kalender.TabIndex = 4;
            // 
            // Tanggal
            // 
            this.Tanggal.Location = new System.Drawing.Point(257, 18);
            this.Tanggal.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.Size = new System.Drawing.Size(120, 20);
            this.Tanggal.TabIndex = 5;
            this.Tanggal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Bulan
            // 
            this.Bulan.Location = new System.Drawing.Point(386, 18);
            this.Bulan.Name = "Bulan";
            this.Bulan.Size = new System.Drawing.Size(120, 20);
            this.Bulan.TabIndex = 1;
            this.Bulan.Text = "Bulan";
            // 
            // Tambah
            // 
            this.Tambah.Location = new System.Drawing.Point(257, 53);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(120, 23);
            this.Tambah.TabIndex = 2;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseVisualStyleBackColor = true;
            this.Tambah.Click += new System.EventHandler(this.Tambah_Click);
            // 
            // Hapus
            // 
            this.Hapus.Location = new System.Drawing.Point(386, 53);
            this.Hapus.Name = "Hapus";
            this.Hapus.Size = new System.Drawing.Size(120, 23);
            this.Hapus.TabIndex = 3;
            this.Hapus.Text = "Hapus";
            this.Hapus.UseVisualStyleBackColor = true;
            this.Hapus.Click += new System.EventHandler(this.Hapus_Click);
            // 
            // Lahir
            // 
            this.Lahir.AutoSize = true;
            this.Lahir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lahir.Location = new System.Drawing.Point(258, 94);
            this.Lahir.Name = "Lahir";
            this.Lahir.Size = new System.Drawing.Size(173, 19);
            this.Lahir.TabIndex = 5;
            this.Lahir.Text = "Tanggal Lahir : 10 Oktober";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 261);
            this.Controls.Add(this.Lahir);
            this.Controls.Add(this.Hapus);
            this.Controls.Add(this.Tambah);
            this.Controls.Add(this.Bulan);
            this.Controls.Add(this.Tanggal);
            this.Controls.Add(this.Kalender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tanggal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Kalender;
        private System.Windows.Forms.NumericUpDown Tanggal;
        private System.Windows.Forms.DomainUpDown Bulan;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.Button Hapus;
        private System.Windows.Forms.Label Lahir;
    }
}

