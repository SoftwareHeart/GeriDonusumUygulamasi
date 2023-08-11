
namespace GeriDonusumUygulamasi
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plastikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aleminumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kagitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKullanicilarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazılımSinamOdevDataSet = new GeriDonusumUygulamasi.YazılımSinamOdevDataSet();
            this.tbl_KullanicilarTableAdapter = new GeriDonusumUygulamasi.YazılımSinamOdevDataSetTableAdapters.Tbl_KullanicilarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanicilarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazılımSinamOdevDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(639, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Carbon Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(348, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(496, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "Çıkış";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(13, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 384);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.kodDataGridViewTextBoxColumn,
            this.camDataGridViewTextBoxColumn,
            this.plastikDataGridViewTextBoxColumn,
            this.aleminumDataGridViewTextBoxColumn,
            this.kagitDataGridViewTextBoxColumn,
            this.bakirDataGridViewTextBoxColumn,
            this.demirDataGridViewTextBoxColumn,
            this.coinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblKullanicilarBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(890, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodDataGridViewTextBoxColumn
            // 
            this.kodDataGridViewTextBoxColumn.DataPropertyName = "Kod";
            this.kodDataGridViewTextBoxColumn.HeaderText = "Kod";
            this.kodDataGridViewTextBoxColumn.Name = "kodDataGridViewTextBoxColumn";
            this.kodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // camDataGridViewTextBoxColumn
            // 
            this.camDataGridViewTextBoxColumn.DataPropertyName = "Cam";
            this.camDataGridViewTextBoxColumn.HeaderText = "Cam";
            this.camDataGridViewTextBoxColumn.Name = "camDataGridViewTextBoxColumn";
            this.camDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // plastikDataGridViewTextBoxColumn
            // 
            this.plastikDataGridViewTextBoxColumn.DataPropertyName = "Plastik";
            this.plastikDataGridViewTextBoxColumn.HeaderText = "Plastik";
            this.plastikDataGridViewTextBoxColumn.Name = "plastikDataGridViewTextBoxColumn";
            this.plastikDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aleminumDataGridViewTextBoxColumn
            // 
            this.aleminumDataGridViewTextBoxColumn.DataPropertyName = "Aleminum";
            this.aleminumDataGridViewTextBoxColumn.HeaderText = "Aleminum";
            this.aleminumDataGridViewTextBoxColumn.Name = "aleminumDataGridViewTextBoxColumn";
            this.aleminumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kagitDataGridViewTextBoxColumn
            // 
            this.kagitDataGridViewTextBoxColumn.DataPropertyName = "Kagit";
            this.kagitDataGridViewTextBoxColumn.HeaderText = "Kagit";
            this.kagitDataGridViewTextBoxColumn.Name = "kagitDataGridViewTextBoxColumn";
            this.kagitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bakirDataGridViewTextBoxColumn
            // 
            this.bakirDataGridViewTextBoxColumn.DataPropertyName = "Bakir";
            this.bakirDataGridViewTextBoxColumn.HeaderText = "Bakir";
            this.bakirDataGridViewTextBoxColumn.Name = "bakirDataGridViewTextBoxColumn";
            this.bakirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // demirDataGridViewTextBoxColumn
            // 
            this.demirDataGridViewTextBoxColumn.DataPropertyName = "Demir";
            this.demirDataGridViewTextBoxColumn.HeaderText = "Demir";
            this.demirDataGridViewTextBoxColumn.Name = "demirDataGridViewTextBoxColumn";
            this.demirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coinDataGridViewTextBoxColumn
            // 
            this.coinDataGridViewTextBoxColumn.DataPropertyName = "Coin";
            this.coinDataGridViewTextBoxColumn.HeaderText = "Coin";
            this.coinDataGridViewTextBoxColumn.Name = "coinDataGridViewTextBoxColumn";
            this.coinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblKullanicilarBindingSource
            // 
            this.tblKullanicilarBindingSource.DataMember = "Tbl_Kullanicilar";
            this.tblKullanicilarBindingSource.DataSource = this.yazılımSinamOdevDataSet;
            // 
            // yazılımSinamOdevDataSet
            // 
            this.yazılımSinamOdevDataSet.DataSetName = "YazılımSinamOdevDataSet";
            this.yazılımSinamOdevDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_KullanicilarTableAdapter
            // 
            this.tbl_KullanicilarTableAdapter.ClearBeforeFill = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(946, 659);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKullanicilarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazılımSinamOdevDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private YazılımSinamOdevDataSet yazılımSinamOdevDataSet;
        private System.Windows.Forms.BindingSource tblKullanicilarBindingSource;
        private YazılımSinamOdevDataSetTableAdapters.Tbl_KullanicilarTableAdapter tbl_KullanicilarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn camDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plastikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aleminumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kagitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coinDataGridViewTextBoxColumn;
    }
}