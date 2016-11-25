namespace Volleyball_Problem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txthasil = new System.Windows.Forms.TextBox();
            this.btnhasil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 11);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 11);
            this.label2.TabIndex = 1;
            this.label2.Text = "Score B";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(80, 20);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(165, 20);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(80, 68);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(165, 20);
            this.txt2.TabIndex = 3;
            // 
            // txthasil
            // 
            this.txthasil.Enabled = false;
            this.txthasil.Location = new System.Drawing.Point(80, 153);
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(125, 20);
            this.txthasil.TabIndex = 4;
            // 
            // btnhasil
            // 
            this.btnhasil.Location = new System.Drawing.Point(80, 110);
            this.btnhasil.Name = "btnhasil";
            this.btnhasil.Size = new System.Drawing.Size(125, 23);
            this.btnhasil.TabIndex = 5;
            this.btnhasil.Text = "Hasil";
            this.btnhasil.UseVisualStyleBackColor = true;
            this.btnhasil.Click += new System.EventHandler(this.Buttonhasil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 193);
            this.Controls.Add(this.btnhasil);
            this.Controls.Add(this.txthasil);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txthasil;
        private System.Windows.Forms.Button btnhasil;
    }
}

