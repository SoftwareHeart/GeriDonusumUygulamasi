
namespace GeriDonusumUygulamasi
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.button1 = new System.Windows.Forms.Button();
            this.kodAlBtn = new System.Windows.Forms.Button();
            this.kodTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(396, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(518, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kodAlBtn
            // 
            this.kodAlBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.kodAlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kodAlBtn.Location = new System.Drawing.Point(753, 180);
            this.kodAlBtn.Name = "kodAlBtn";
            this.kodAlBtn.Size = new System.Drawing.Size(141, 37);
            this.kodAlBtn.TabIndex = 1;
            this.kodAlBtn.Text = "Hemen Al";
            this.kodAlBtn.UseVisualStyleBackColor = false;
            this.kodAlBtn.Click += new System.EventHandler(this.kodAlBtn_Click);
            // 
            // kodTxt
            // 
            this.kodTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kodTxt.Location = new System.Drawing.Point(580, 46);
            this.kodTxt.MaxLength = 6;
            this.kodTxt.Name = "kodTxt";
            this.kodTxt.Size = new System.Drawing.Size(334, 28);
            this.kodTxt.TabIndex = 2;
            this.kodTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.kodTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sadece_harf_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(391, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "SHA-256 Kodu :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(444, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kodun yok mu? Hemen Al ===>>>";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.AliceBlue;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(396, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(518, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Admin Girişi";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(920, 219);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kodTxt);
            this.Controls.Add(this.kodAlBtn);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "GirisEkrani";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button kodAlBtn;
        private System.Windows.Forms.TextBox kodTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}

