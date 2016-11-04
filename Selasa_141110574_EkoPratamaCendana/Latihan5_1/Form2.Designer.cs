namespace Latihan5_1
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Background (Cover)");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Background (Text)");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("warna", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.tree = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.warnatext = new System.Windows.Forms.ComboBox();
            this.warnaback = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.Location = new System.Drawing.Point(12, 12);
            this.tree.Name = "tree";
            treeNode1.Name = "Node5";
            treeNode1.Text = "Background (Cover)";
            treeNode2.Name = "Node6";
            treeNode2.Text = "Background (Text)";
            treeNode3.Name = "Node4";
            treeNode3.Text = "warna";
            this.tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tree.Size = new System.Drawing.Size(137, 237);
            this.tree.TabIndex = 0;
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 11);
            this.label1.TabIndex = 1;
            this.label1.Text = "Background Color";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 11);
            this.label2.TabIndex = 2;
            this.label2.Text = "Background text";
            // 
            // warnatext
            // 
            this.warnatext.FormattingEnabled = true;
            this.warnatext.Location = new System.Drawing.Point(166, 92);
            this.warnatext.Name = "warnatext";
            this.warnatext.Size = new System.Drawing.Size(202, 19);
            this.warnatext.TabIndex = 3;
            this.warnatext.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.warnatext_DrawItem);
            this.warnatext.SelectedIndexChanged += new System.EventHandler(this.warnatext_SelectedIndexChanged);
            // 
            // warnaback
            // 
            this.warnaback.FormattingEnabled = true;
            this.warnaback.Location = new System.Drawing.Point(166, 26);
            this.warnaback.Name = "warnaback";
            this.warnaback.Size = new System.Drawing.Size(202, 19);
            this.warnaback.TabIndex = 4;
            this.warnaback.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.warnaback_DrawItem);
            this.warnaback.SelectedIndexChanged += new System.EventHandler(this.warnaback_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.warnaback);
            this.Controls.Add(this.warnatext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tree);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox warnatext;
        private System.Windows.Forms.ComboBox warnaback;
        private System.Windows.Forms.Button button1;
    }
}