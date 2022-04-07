namespace Kura
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
            this.lbx_tum = new System.Windows.Forms.ListBox();
            this.lbx_secilen = new System.Windows.Forms.ListBox();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_sec = new System.Windows.Forms.Button();
            this.txt_kisi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx_tum
            // 
            this.lbx_tum.FormattingEnabled = true;
            this.lbx_tum.Location = new System.Drawing.Point(145, 41);
            this.lbx_tum.Name = "lbx_tum";
            this.lbx_tum.Size = new System.Drawing.Size(120, 303);
            this.lbx_tum.TabIndex = 0;
            // 
            // lbx_secilen
            // 
            this.lbx_secilen.FormattingEnabled = true;
            this.lbx_secilen.Location = new System.Drawing.Point(301, 41);
            this.lbx_secilen.Name = "lbx_secilen";
            this.lbx_secilen.Size = new System.Drawing.Size(120, 303);
            this.lbx_secilen.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(167, 363);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_sec
            // 
            this.btn_sec.Location = new System.Drawing.Point(331, 363);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(75, 23);
            this.btn_sec.TabIndex = 3;
            this.btn_sec.Text = "Seç";
            this.btn_sec.UseVisualStyleBackColor = true;
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // txt_kisi
            // 
            this.txt_kisi.Location = new System.Drawing.Point(21, 184);
            this.txt_kisi.Name = "txt_kisi";
            this.txt_kisi.Size = new System.Drawing.Size(100, 20);
            this.txt_kisi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("David", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(151, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tüm Numaralar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("David", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(328, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seçilenler";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(545, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kisi);
            this.Controls.Add(this.btn_sec);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.lbx_secilen);
            this.Controls.Add(this.lbx_tum);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Şans Kutusu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_tum;
        private System.Windows.Forms.ListBox lbx_secilen;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_sec;
        private System.Windows.Forms.TextBox txt_kisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

