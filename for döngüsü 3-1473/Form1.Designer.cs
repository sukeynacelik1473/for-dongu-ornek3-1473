namespace for_döngüsü_3_1473
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
            this.lbSayilar = new System.Windows.Forms.ListBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSayilar
            // 
            this.lbSayilar.FormattingEnabled = true;
            this.lbSayilar.Location = new System.Drawing.Point(160, 68);
            this.lbSayilar.Name = "lbSayilar";
            this.lbSayilar.Size = new System.Drawing.Size(135, 264);
            this.lbSayilar.TabIndex = 0;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(12, 97);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(124, 63);
            this.btnGoster.TabIndex = 1;
            this.btnGoster.Text = "GÖSTER";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(12, 68);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(124, 20);
            this.txtSayi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(322, 450);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.lbSayilar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayilar;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.TextBox txtSayi;
    }
}

