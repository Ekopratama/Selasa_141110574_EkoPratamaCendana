namespace Latihan_3_1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ukuran = new System.Windows.Forms.ToolStripComboBox();
            this.tebal = new System.Windows.Forms.ToolStripButton();
            this.miring = new System.Windows.Forms.ToolStripButton();
            this.garis = new System.Windows.Forms.ToolStripButton();
            this.jenis = new System.Windows.Forms.ToolStripComboBox();
            this.warna = new System.Windows.Forms.ToolStripComboBox();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ukuran,
            this.tebal,
            this.miring,
            this.garis,
            this.jenis,
            this.warna});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(530, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ukuran
            // 
            this.ukuran.Name = "ukuran";
            this.ukuran.Size = new System.Drawing.Size(121, 28);
            this.ukuran.SelectedIndexChanged += new System.EventHandler(this.ukuran_SelectedIndexChanged);
            this.ukuran.Click += new System.EventHandler(this.ukuran_Click);
            // 
            // tebal
            // 
            this.tebal.CheckOnClick = true;
            this.tebal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tebal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tebal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tebal.Name = "tebal";
            this.tebal.Size = new System.Drawing.Size(24, 25);
            this.tebal.Text = "B";
            this.tebal.Click += new System.EventHandler(this.tebal_Click);
            // 
            // miring
            // 
            this.miring.CheckOnClick = true;
            this.miring.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.miring.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miring.Image = ((System.Drawing.Image)(resources.GetObject("miring.Image")));
            this.miring.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miring.Name = "miring";
            this.miring.Size = new System.Drawing.Size(23, 25);
            this.miring.Text = "I";
            this.miring.Click += new System.EventHandler(this.miring_Click);
            // 
            // garis
            // 
            this.garis.CheckOnClick = true;
            this.garis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.garis.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garis.Image = ((System.Drawing.Image)(resources.GetObject("garis.Image")));
            this.garis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.garis.Name = "garis";
            this.garis.Size = new System.Drawing.Size(25, 25);
            this.garis.Text = "U";
            this.garis.Click += new System.EventHandler(this.garis_Click);
            // 
            // jenis
            // 
            this.jenis.Name = "jenis";
            this.jenis.Size = new System.Drawing.Size(121, 28);
            this.jenis.SelectedIndexChanged += new System.EventHandler(this.jenis_SelectedIndexChanged);
            this.jenis.Click += new System.EventHandler(this.jenis_Click);
            // 
            // warna
            // 
            this.warna.Name = "warna";
            this.warna.Size = new System.Drawing.Size(121, 28);
            this.warna.Click += new System.EventHandler(this.warna_Click);
            // 
            // rtb1
            // 
            this.rtb1.Location = new System.Drawing.Point(0, 28);
            this.rtb1.Name = "rtb1";
            this.rtb1.Size = new System.Drawing.Size(530, 382);
            this.rtb1.TabIndex = 1;
            this.rtb1.Text = "";
            this.rtb1.SelectionChanged += new System.EventHandler(this.rtb1_SelectionChanged);
            this.rtb1.TextChanged += new System.EventHandler(this.rtb1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 422);
            this.Controls.Add(this.rtb1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox ukuran;
        private System.Windows.Forms.ToolStripButton tebal;
        private System.Windows.Forms.ToolStripButton miring;
        private System.Windows.Forms.ToolStripButton garis;
        private System.Windows.Forms.ToolStripComboBox jenis;
        private System.Windows.Forms.ToolStripComboBox warna;
        private System.Windows.Forms.RichTextBox rtb1;
    }
}

