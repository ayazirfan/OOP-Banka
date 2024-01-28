namespace OOP_Workshop1501
{
    partial class Form1
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
            btnKaydet = new Button();
            btnSil = new Button();
            btnHesap = new Button();
            lstListe = new ListBox();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(29, 32);
            btnKaydet.Margin = new Padding(7, 8, 7, 8);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(171, 61);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "KAYDET";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(210, 32);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(207, 61);
            btnSil.TabIndex = 1;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnHesap
            // 
            btnHesap.Location = new Point(423, 32);
            btnHesap.Name = "btnHesap";
            btnHesap.Size = new Size(263, 62);
            btnHesap.TabIndex = 2;
            btnHesap.Text = "Hesap Aç";
            btnHesap.UseVisualStyleBackColor = true;
            btnHesap.Click += btnHesap_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 40;
            lstListe.Location = new Point(29, 100);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(657, 204);
            lstListe.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 624);
            Controls.Add(lstListe);
            Controls.Add(btnHesap);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnKaydet;
        private Button btnSil;
        private Button btnHesap;
        private ListBox lstListe;
    }
}
