
namespace WF1
{
    partial class SiAge
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Algo = new System.Windows.Forms.ToolStripMenuItem();
            this.Somme = new System.Windows.Forms.ToolStripMenuItem();
            this.Validation = new System.Windows.Forms.ToolStripMenuItem();
            this.Multi = new System.Windows.Forms.ToolStripMenuItem();
            this.Fact = new System.Windows.Forms.ToolStripMenuItem();
            this.Imp = new System.Windows.Forms.ToolStripMenuItem();
            this.NPremier = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClickThis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Algo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // Algo
            // 
            this.Algo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Somme,
            this.Validation,
            this.Multi,
            this.Fact,
            this.Imp,
            this.NPremier});
            this.Algo.Name = "Algo";
            this.Algo.Size = new System.Drawing.Size(44, 20);
            this.Algo.Text = "Algo";
            // 
            // Somme
            // 
            this.Somme.Name = "Somme";
            this.Somme.Size = new System.Drawing.Size(162, 22);
            this.Somme.Text = "Somme";
            // 
            // Validation
            // 
            this.Validation.Name = "Validation";
            this.Validation.Size = new System.Drawing.Size(162, 22);
            this.Validation.Text = "Validation Age";
            // 
            // Multi
            // 
            this.Multi.Name = "Multi";
            this.Multi.Size = new System.Drawing.Size(162, 22);
            this.Multi.Text = "Multi";
            // 
            // Fact
            // 
            this.Fact.Name = "Fact";
            this.Fact.Size = new System.Drawing.Size(162, 22);
            this.Fact.Text = "Fact";
            // 
            // Imp
            // 
            this.Imp.Name = "Imp";
            this.Imp.Size = new System.Drawing.Size(162, 22);
            this.Imp.Text = "Imp";
            // 
            // NPremier
            // 
            this.NPremier.Name = "NPremier";
            this.NPremier.Size = new System.Drawing.Size(162, 22);
            this.NPremier.Text = "Nombre Premier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entrez votre age :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnClickThis
            // 
            this.btnClickThis.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClickThis.Location = new System.Drawing.Point(725, 454);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(63, 29);
            this.btnClickThis.TabIndex = 7;
            this.btnClickThis.Text = "    Valider";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(257, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vous etes sur le programme Si Age\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(327, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "gggggggggg";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Valider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClickThis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Valider";
            this.Text = "    Valider";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem Algo;
        private System.Windows.Forms.ToolStripMenuItem Somme;
        private System.Windows.Forms.ToolStripMenuItem Validation;
        private System.Windows.Forms.ToolStripMenuItem Multi;
        private System.Windows.Forms.ToolStripMenuItem Fact;
        private System.Windows.Forms.ToolStripMenuItem Imp;
        private System.Windows.Forms.ToolStripMenuItem NPremier;
        private System.Windows.Forms.Button btnClickThis ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

