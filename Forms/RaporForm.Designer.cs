namespace AracKiralamaSistemi.Forms
{
    partial class RaporForm
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
            this.tabControlRaporlar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAktifKiralamalar = new System.Windows.Forms.DataGridView();
            this.btnTeslimAl = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvEnCokKiralananlar = new System.Windows.Forms.DataGridView();
            this.tabControlRaporlar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktifKiralamalar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCokKiralananlar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlRaporlar
            // 
            this.tabControlRaporlar.Controls.Add(this.tabPage1);
            this.tabControlRaporlar.Controls.Add(this.tabPage2);
            this.tabControlRaporlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRaporlar.Location = new System.Drawing.Point(0, 0);
            this.tabControlRaporlar.Name = "tabControlRaporlar";
            this.tabControlRaporlar.SelectedIndex = 0;
            this.tabControlRaporlar.Size = new System.Drawing.Size(943, 547);
            this.tabControlRaporlar.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTeslimAl);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(935, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Aktif Kiralamalar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(935, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "En Çok Kiralanan Araçlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAktifKiralamalar);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 472);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktif Kiralama Sözleşmeleri";
            // 
            // dgvAktifKiralamalar
            // 
            this.dgvAktifKiralamalar.AllowUserToAddRows = false;
            this.dgvAktifKiralamalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAktifKiralamalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktifKiralamalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAktifKiralamalar.Location = new System.Drawing.Point(3, 16);
            this.dgvAktifKiralamalar.Name = "dgvAktifKiralamalar";
            this.dgvAktifKiralamalar.ReadOnly = true;
            this.dgvAktifKiralamalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAktifKiralamalar.Size = new System.Drawing.Size(913, 453);
            this.dgvAktifKiralamalar.TabIndex = 0;
            this.dgvAktifKiralamalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAktifKiralamalar_CellContentClick);
            this.dgvAktifKiralamalar.SelectionChanged += new System.EventHandler(this.dgvAktifKiralamalar_SelectionChanged);
            // 
            // btnTeslimAl
            // 
            this.btnTeslimAl.Location = new System.Drawing.Point(423, 481);
            this.btnTeslimAl.Name = "btnTeslimAl";
            this.btnTeslimAl.Size = new System.Drawing.Size(129, 29);
            this.btnTeslimAl.TabIndex = 1;
            this.btnTeslimAl.Text = "Seçili Aracı Teslim Al";
            this.btnTeslimAl.UseVisualStyleBackColor = true;
            this.btnTeslimAl.Click += new System.EventHandler(this.btnTeslimAl_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvEnCokKiralananlar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(929, 515);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "En Çok Kiralanan Araçlar (Top 5)";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvEnCokKiralananlar
            // 
            this.dgvEnCokKiralananlar.AllowUserToAddRows = false;
            this.dgvEnCokKiralananlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnCokKiralananlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnCokKiralananlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEnCokKiralananlar.Location = new System.Drawing.Point(3, 16);
            this.dgvEnCokKiralananlar.Name = "dgvEnCokKiralananlar";
            this.dgvEnCokKiralananlar.ReadOnly = true;
            this.dgvEnCokKiralananlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEnCokKiralananlar.Size = new System.Drawing.Size(923, 496);
            this.dgvEnCokKiralananlar.TabIndex = 0;
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 547);
            this.Controls.Add(this.tabControlRaporlar);
            this.Name = "RaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            this.tabControlRaporlar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktifKiralamalar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnCokKiralananlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRaporlar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAktifKiralamalar;
        private System.Windows.Forms.Button btnTeslimAl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvEnCokKiralananlar;
    }
}