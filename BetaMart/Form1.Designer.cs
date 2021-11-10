
namespace BetaMart
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.betaMartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.betaMartDataSet = new BetaMart.BetaMartDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Tambah = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalMasukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiredProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gambarProductDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.SAVE = new System.Windows.Forms.Button();
            this.CANCEL = new System.Windows.Forms.Button();
            this.EDIT = new System.Windows.Forms.Button();
            this.NEW = new System.Windows.Forms.Button();
            this.beta_MartTableAdapter = new BetaMart.BetaMartDataSetTableAdapters.Beta_MartTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betaMartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaMartDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Tambah);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 336);
            this.panel1.TabIndex = 0;
            this.panel1.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(141, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Brand Product";
            this.label7.UseWaitCursor = true;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaMartBindingSource, "Brand Product", true));
            this.textBox6.Location = new System.Drawing.Point(261, 264);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(240, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.UseWaitCursor = true;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // betaMartBindingSource
            // 
            this.betaMartBindingSource.DataMember = "Beta_Mart";
            this.betaMartBindingSource.DataSource = this.betaMartDataSet;
            // 
            // betaMartDataSet
            // 
            this.betaMartDataSet.DataSetName = "BetaMartDataSet";
            this.betaMartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(141, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Expired Product";
            this.label6.UseWaitCursor = true;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaMartBindingSource, "Expired Product", true));
            this.textBox5.Location = new System.Drawing.Point(261, 227);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(240, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(237, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "B E T A M A R T";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tanggal Masuk";
            this.label4.UseWaitCursor = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaMartBindingSource, "Tanggal Masuk", true));
            this.textBox4.Location = new System.Drawing.Point(261, 189);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(141, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jumlah Product";
            this.label3.UseWaitCursor = true;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaMartBindingSource, "Jumlah Product", true));
            this.textBox3.Location = new System.Drawing.Point(261, 150);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Harga Product";
            this.label2.UseWaitCursor = true;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaMartBindingSource, "Harga Product", true));
            this.textBox2.Location = new System.Drawing.Point(261, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseWaitCursor = true;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama Product";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.betaMartBindingSource, "Nama Product", true));
            this.textBox1.Location = new System.Drawing.Point(261, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.UseWaitCursor = true;
            // 
            // Tambah
            // 
            this.Tambah.BackColor = System.Drawing.SystemColors.Highlight;
            this.Tambah.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tambah.Location = new System.Drawing.Point(589, 290);
            this.Tambah.Name = "Tambah";
            this.Tambah.Size = new System.Drawing.Size(129, 33);
            this.Tambah.TabIndex = 1;
            this.Tambah.Text = "Tambah";
            this.Tambah.UseVisualStyleBackColor = false;
            this.Tambah.UseWaitCursor = true;
            this.Tambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.betaMartBindingSource, "Gambar Product", true));
            this.pictureBox1.Location = new System.Drawing.Point(537, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 264);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDProductDataGridViewTextBoxColumn,
            this.namaProductDataGridViewTextBoxColumn,
            this.hargaProductDataGridViewTextBoxColumn,
            this.jumlahProductDataGridViewTextBoxColumn,
            this.tanggalMasukDataGridViewTextBoxColumn,
            this.expiredProductDataGridViewTextBoxColumn,
            this.brandProductDataGridViewTextBoxColumn,
            this.gambarProductDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.betaMartBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 358);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(724, 258);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.UseWaitCursor = true;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // iDProductDataGridViewTextBoxColumn
            // 
            this.iDProductDataGridViewTextBoxColumn.DataPropertyName = "ID Product";
            this.iDProductDataGridViewTextBoxColumn.HeaderText = "ID Product";
            this.iDProductDataGridViewTextBoxColumn.Name = "iDProductDataGridViewTextBoxColumn";
            // 
            // namaProductDataGridViewTextBoxColumn
            // 
            this.namaProductDataGridViewTextBoxColumn.DataPropertyName = "Nama Product";
            this.namaProductDataGridViewTextBoxColumn.HeaderText = "Nama Product";
            this.namaProductDataGridViewTextBoxColumn.Name = "namaProductDataGridViewTextBoxColumn";
            // 
            // hargaProductDataGridViewTextBoxColumn
            // 
            this.hargaProductDataGridViewTextBoxColumn.DataPropertyName = "Harga Product";
            this.hargaProductDataGridViewTextBoxColumn.HeaderText = "Harga Product";
            this.hargaProductDataGridViewTextBoxColumn.Name = "hargaProductDataGridViewTextBoxColumn";
            // 
            // jumlahProductDataGridViewTextBoxColumn
            // 
            this.jumlahProductDataGridViewTextBoxColumn.DataPropertyName = "Jumlah Product";
            this.jumlahProductDataGridViewTextBoxColumn.HeaderText = "Jumlah Product";
            this.jumlahProductDataGridViewTextBoxColumn.Name = "jumlahProductDataGridViewTextBoxColumn";
            // 
            // tanggalMasukDataGridViewTextBoxColumn
            // 
            this.tanggalMasukDataGridViewTextBoxColumn.DataPropertyName = "Tanggal Masuk";
            this.tanggalMasukDataGridViewTextBoxColumn.HeaderText = "Tanggal Masuk";
            this.tanggalMasukDataGridViewTextBoxColumn.Name = "tanggalMasukDataGridViewTextBoxColumn";
            // 
            // expiredProductDataGridViewTextBoxColumn
            // 
            this.expiredProductDataGridViewTextBoxColumn.DataPropertyName = "Expired Product";
            this.expiredProductDataGridViewTextBoxColumn.HeaderText = "Expired Product";
            this.expiredProductDataGridViewTextBoxColumn.Name = "expiredProductDataGridViewTextBoxColumn";
            // 
            // brandProductDataGridViewTextBoxColumn
            // 
            this.brandProductDataGridViewTextBoxColumn.DataPropertyName = "Brand Product";
            this.brandProductDataGridViewTextBoxColumn.HeaderText = "Brand Product";
            this.brandProductDataGridViewTextBoxColumn.Name = "brandProductDataGridViewTextBoxColumn";
            // 
            // gambarProductDataGridViewImageColumn
            // 
            this.gambarProductDataGridViewImageColumn.DataPropertyName = "Gambar Product";
            this.gambarProductDataGridViewImageColumn.HeaderText = "Gambar Product";
            this.gambarProductDataGridViewImageColumn.Name = "gambarProductDataGridViewImageColumn";
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SAVE.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE.Location = new System.Drawing.Point(653, 637);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(98, 26);
            this.SAVE.TabIndex = 5;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.UseWaitCursor = true;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // CANCEL
            // 
            this.CANCEL.BackColor = System.Drawing.Color.Gold;
            this.CANCEL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANCEL.Location = new System.Drawing.Point(556, 637);
            this.CANCEL.Name = "CANCEL";
            this.CANCEL.Size = new System.Drawing.Size(91, 26);
            this.CANCEL.TabIndex = 4;
            this.CANCEL.Text = "CANCEL";
            this.CANCEL.UseVisualStyleBackColor = false;
            this.CANCEL.UseWaitCursor = true;
            this.CANCEL.Click += new System.EventHandler(this.CANCEL_Click);
            // 
            // EDIT
            // 
            this.EDIT.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.EDIT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EDIT.Location = new System.Drawing.Point(460, 636);
            this.EDIT.Name = "EDIT";
            this.EDIT.Size = new System.Drawing.Size(90, 28);
            this.EDIT.TabIndex = 3;
            this.EDIT.Text = "EDIT";
            this.EDIT.UseVisualStyleBackColor = false;
            this.EDIT.UseWaitCursor = true;
            this.EDIT.Click += new System.EventHandler(this.EDIT_Click);
            // 
            // NEW
            // 
            this.NEW.BackColor = System.Drawing.Color.YellowGreen;
            this.NEW.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NEW.Location = new System.Drawing.Point(351, 637);
            this.NEW.Name = "NEW";
            this.NEW.Size = new System.Drawing.Size(100, 26);
            this.NEW.TabIndex = 2;
            this.NEW.Text = "NEW";
            this.NEW.UseVisualStyleBackColor = false;
            this.NEW.UseWaitCursor = true;
            this.NEW.Click += new System.EventHandler(this.NEW_Click);
            // 
            // beta_MartTableAdapter
            // 
            this.beta_MartTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(243, 638);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 706);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NEW);
            this.Controls.Add(this.EDIT);
            this.Controls.Add(this.CANCEL);
            this.Controls.Add(this.SAVE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "SAYA GANTENG";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betaMartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betaMartDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Tambah;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button CANCEL;
        private System.Windows.Forms.Button EDIT;
        private System.Windows.Forms.Button NEW;
        private BetaMartDataSet betaMartDataSet;
        private System.Windows.Forms.BindingSource betaMartBindingSource;
        private BetaMartDataSetTableAdapters.Beta_MartTableAdapter beta_MartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalMasukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiredProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn gambarProductDataGridViewImageColumn;
        private System.Windows.Forms.Button button1;
    }
}

