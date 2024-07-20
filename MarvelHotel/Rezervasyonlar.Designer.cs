namespace MarvelHotel
{
    partial class Rezervasyonlar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marvelHotelDataSet = new MarvelHotel.MarvelHotelDataSet();
            this.marvelHotelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervasyonlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rezervasyonlarTableAdapter = new MarvelHotel.MarvelHotelDataSetTableAdapters.RezervasyonlarTableAdapter();
            this.rezervasyonidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giristarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikistarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marvelHotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marvelHotelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonlarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rezervasyonidDataGridViewTextBoxColumn,
            this.musteriidDataGridViewTextBoxColumn,
            this.odaidDataGridViewTextBoxColumn,
            this.giristarihiDataGridViewTextBoxColumn,
            this.cikistarihiDataGridViewTextBoxColumn,
            this.toplamucretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rezervasyonlarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // marvelHotelDataSet
            // 
            this.marvelHotelDataSet.DataSetName = "MarvelHotelDataSet";
            this.marvelHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marvelHotelDataSetBindingSource
            // 
            this.marvelHotelDataSetBindingSource.DataSource = this.marvelHotelDataSet;
            this.marvelHotelDataSetBindingSource.Position = 0;
            // 
            // rezervasyonlarBindingSource
            // 
            this.rezervasyonlarBindingSource.DataMember = "Rezervasyonlar";
            this.rezervasyonlarBindingSource.DataSource = this.marvelHotelDataSetBindingSource;
            // 
            // rezervasyonlarTableAdapter
            // 
            this.rezervasyonlarTableAdapter.ClearBeforeFill = true;
            // 
            // rezervasyonidDataGridViewTextBoxColumn
            // 
            this.rezervasyonidDataGridViewTextBoxColumn.DataPropertyName = "rezervasyon_id";
            this.rezervasyonidDataGridViewTextBoxColumn.HeaderText = "rezervasyon_id";
            this.rezervasyonidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rezervasyonidDataGridViewTextBoxColumn.Name = "rezervasyonidDataGridViewTextBoxColumn";
            this.rezervasyonidDataGridViewTextBoxColumn.ReadOnly = true;
            this.rezervasyonidDataGridViewTextBoxColumn.Width = 125;
            // 
            // musteriidDataGridViewTextBoxColumn
            // 
            this.musteriidDataGridViewTextBoxColumn.DataPropertyName = "musteri_id";
            this.musteriidDataGridViewTextBoxColumn.HeaderText = "musteri_id";
            this.musteriidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.musteriidDataGridViewTextBoxColumn.Name = "musteriidDataGridViewTextBoxColumn";
            this.musteriidDataGridViewTextBoxColumn.Width = 125;
            // 
            // odaidDataGridViewTextBoxColumn
            // 
            this.odaidDataGridViewTextBoxColumn.DataPropertyName = "oda_id";
            this.odaidDataGridViewTextBoxColumn.HeaderText = "oda_id";
            this.odaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaidDataGridViewTextBoxColumn.Name = "odaidDataGridViewTextBoxColumn";
            this.odaidDataGridViewTextBoxColumn.Width = 125;
            // 
            // giristarihiDataGridViewTextBoxColumn
            // 
            this.giristarihiDataGridViewTextBoxColumn.DataPropertyName = "giris_tarihi";
            this.giristarihiDataGridViewTextBoxColumn.HeaderText = "giris_tarihi";
            this.giristarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giristarihiDataGridViewTextBoxColumn.Name = "giristarihiDataGridViewTextBoxColumn";
            this.giristarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // cikistarihiDataGridViewTextBoxColumn
            // 
            this.cikistarihiDataGridViewTextBoxColumn.DataPropertyName = "cikis_tarihi";
            this.cikistarihiDataGridViewTextBoxColumn.HeaderText = "cikis_tarihi";
            this.cikistarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cikistarihiDataGridViewTextBoxColumn.Name = "cikistarihiDataGridViewTextBoxColumn";
            this.cikistarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamucretDataGridViewTextBoxColumn
            // 
            this.toplamucretDataGridViewTextBoxColumn.DataPropertyName = "toplam_ucret";
            this.toplamucretDataGridViewTextBoxColumn.HeaderText = "toplam_ucret";
            this.toplamucretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamucretDataGridViewTextBoxColumn.Name = "toplamucretDataGridViewTextBoxColumn";
            this.toplamucretDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ana Sayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rezervasyonlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Rezervasyonlar";
            this.Text = "Rezervasyonlar";
            this.Load += new System.EventHandler(this.Rezervasyonlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marvelHotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marvelHotelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezervasyonlarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource marvelHotelDataSetBindingSource;
        private MarvelHotelDataSet marvelHotelDataSet;
        private System.Windows.Forms.BindingSource rezervasyonlarBindingSource;
        private MarvelHotelDataSetTableAdapters.RezervasyonlarTableAdapter rezervasyonlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezervasyonidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giristarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikistarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}