
namespace WFA_Example_1
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
            this.btnIslem1 = new System.Windows.Forms.Button();
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.btnIslem2 = new System.Windows.Forms.Button();
            this.btnCift = new System.Windows.Forms.Button();
            this.btnAlfabe = new System.Windows.Forms.Button();
            this.btnToplam = new System.Windows.Forms.Button();
            this.btnCarpim = new System.Windows.Forms.Button();
            this.btnIslem3 = new System.Windows.Forms.Button();
            this.btnYillar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIslem1
            // 
            this.btnIslem1.Location = new System.Drawing.Point(39, 37);
            this.btnIslem1.Name = "btnIslem1";
            this.btnIslem1.Size = new System.Drawing.Size(125, 38);
            this.btnIslem1.TabIndex = 0;
            this.btnIslem1.Text = "1-1000";
            this.btnIslem1.UseVisualStyleBackColor = true;
            this.btnIslem1.Click += new System.EventHandler(this.btnIslem1_Click);
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.Location = new System.Drawing.Point(245, 37);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(408, 342);
            this.lstSonuc.TabIndex = 1;
            // 
            // btnIslem2
            // 
            this.btnIslem2.Location = new System.Drawing.Point(39, 81);
            this.btnIslem2.Name = "btnIslem2";
            this.btnIslem2.Size = new System.Drawing.Size(125, 38);
            this.btnIslem2.TabIndex = 0;
            this.btnIslem2.Text = "1000-1";
            this.btnIslem2.UseVisualStyleBackColor = true;
            this.btnIslem2.Click += new System.EventHandler(this.btnIslem2_Click);
            // 
            // btnCift
            // 
            this.btnCift.Location = new System.Drawing.Point(39, 125);
            this.btnCift.Name = "btnCift";
            this.btnCift.Size = new System.Drawing.Size(125, 38);
            this.btnCift.TabIndex = 0;
            this.btnCift.Text = "1-1000 Çift";
            this.btnCift.UseVisualStyleBackColor = true;
            this.btnCift.Click += new System.EventHandler(this.btnCift_Click);
            // 
            // btnAlfabe
            // 
            this.btnAlfabe.Location = new System.Drawing.Point(39, 169);
            this.btnAlfabe.Name = "btnAlfabe";
            this.btnAlfabe.Size = new System.Drawing.Size(125, 38);
            this.btnAlfabe.TabIndex = 0;
            this.btnAlfabe.Text = "A\'dan Z\'ye";
            this.btnAlfabe.UseVisualStyleBackColor = true;
            this.btnAlfabe.Click += new System.EventHandler(this.btnAlfabe_Click);
            // 
            // btnToplam
            // 
            this.btnToplam.Location = new System.Drawing.Point(39, 213);
            this.btnToplam.Name = "btnToplam";
            this.btnToplam.Size = new System.Drawing.Size(125, 38);
            this.btnToplam.TabIndex = 0;
            this.btnToplam.Text = "1-100 Toplam";
            this.btnToplam.UseVisualStyleBackColor = true;
            this.btnToplam.Click += new System.EventHandler(this.btnToplam_Click);
            // 
            // btnCarpim
            // 
            this.btnCarpim.Location = new System.Drawing.Point(39, 257);
            this.btnCarpim.Name = "btnCarpim";
            this.btnCarpim.Size = new System.Drawing.Size(125, 38);
            this.btnCarpim.TabIndex = 0;
            this.btnCarpim.Text = "Çarpım Tablosu";
            this.btnCarpim.UseVisualStyleBackColor = true;
            this.btnCarpim.Click += new System.EventHandler(this.btnCarpim_Click);
            // 
            // btnIslem3
            // 
            this.btnIslem3.Location = new System.Drawing.Point(39, 301);
            this.btnIslem3.Name = "btnIslem3";
            this.btnIslem3.Size = new System.Drawing.Size(125, 38);
            this.btnIslem3.TabIndex = 0;
            this.btnIslem3.Text = "İşlem";
            this.btnIslem3.UseVisualStyleBackColor = true;
            this.btnIslem3.Click += new System.EventHandler(this.btnIslem3_Click);
            // 
            // btnYillar
            // 
            this.btnYillar.Location = new System.Drawing.Point(39, 345);
            this.btnYillar.Name = "btnYillar";
            this.btnYillar.Size = new System.Drawing.Size(125, 38);
            this.btnYillar.TabIndex = 0;
            this.btnYillar.Text = "Yıllar";
            this.btnYillar.UseVisualStyleBackColor = true;
            this.btnYillar.Click += new System.EventHandler(this.btnYillar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 431);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.btnYillar);
            this.Controls.Add(this.btnIslem3);
            this.Controls.Add(this.btnCarpim);
            this.Controls.Add(this.btnToplam);
            this.Controls.Add(this.btnAlfabe);
            this.Controls.Add(this.btnCift);
            this.Controls.Add(this.btnIslem2);
            this.Controls.Add(this.btnIslem1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIslem1;
        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Button btnIslem2;
        private System.Windows.Forms.Button btnCift;
        private System.Windows.Forms.Button btnAlfabe;
        private System.Windows.Forms.Button btnToplam;
        private System.Windows.Forms.Button btnCarpim;
        private System.Windows.Forms.Button btnIslem3;
        private System.Windows.Forms.Button btnYillar;
    }
}

