namespace MarvelHotel
{
    partial class OdalarBilgisi
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
            this.odalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odalarTableAdapter = new MarvelHotel.MarvelHotelDataSetTableAdapters.OdalarTableAdapter();
            this.odaidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odanumarasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odatipiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ucretDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marvelHotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.odaidDataGridViewTextBoxColumn,
            this.odanumarasiDataGridViewTextBoxColumn,
            this.odatipiDataGridViewTextBoxColumn,
            this.ucretDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.odalarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(163, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(553, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // marvelHotelDataSet
            // 
            this.marvelHotelDataSet.DataSetName = "MarvelHotelDataSet";
            this.marvelHotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // odalarBindingSource
            // 
            this.odalarBindingSource.DataMember = "Odalar";
            this.odalarBindingSource.DataSource = this.marvelHotelDataSet;
            // 
            // odalarTableAdapter
            // 
            this.odalarTableAdapter.ClearBeforeFill = true;
            // 
            // odaidDataGridViewTextBoxColumn
            // 
            this.odaidDataGridViewTextBoxColumn.DataPropertyName = "oda_id";
            this.odaidDataGridViewTextBoxColumn.HeaderText = "oda_id";
            this.odaidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odaidDataGridViewTextBoxColumn.Name = "odaidDataGridViewTextBoxColumn";
            this.odaidDataGridViewTextBoxColumn.ReadOnly = true;
            this.odaidDataGridViewTextBoxColumn.Width = 125;
            // 
            // odanumarasiDataGridViewTextBoxColumn
            // 
            this.odanumarasiDataGridViewTextBoxColumn.DataPropertyName = "oda_numarasi";
            this.odanumarasiDataGridViewTextBoxColumn.HeaderText = "oda_numarasi";
            this.odanumarasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odanumarasiDataGridViewTextBoxColumn.Name = "odanumarasiDataGridViewTextBoxColumn";
            this.odanumarasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // odatipiDataGridViewTextBoxColumn
            // 
            this.odatipiDataGridViewTextBoxColumn.DataPropertyName = "oda_tipi";
            this.odatipiDataGridViewTextBoxColumn.HeaderText = "oda_tipi";
            this.odatipiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odatipiDataGridViewTextBoxColumn.Name = "odatipiDataGridViewTextBoxColumn";
            this.odatipiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ucretDataGridViewTextBoxColumn
            // 
            this.ucretDataGridViewTextBoxColumn.DataPropertyName = "ucret";
            this.ucretDataGridViewTextBoxColumn.HeaderText = "ucret";
            this.ucretDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ucretDataGridViewTextBoxColumn.Name = "ucretDataGridViewTextBoxColumn";
            this.ucretDataGridViewTextBoxColumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ana Sayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OdalarBilgisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OdalarBilgisi";
            this.Text = "OdalarBilgisi";
            this.Load += new System.EventHandler(this.OdalarBilgisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marvelHotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odalarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MarvelHotelDataSet marvelHotelDataSet;
        private System.Windows.Forms.BindingSource odalarBindingSource;
        private MarvelHotelDataSetTableAdapters.OdalarTableAdapter odalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn odaidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odanumarasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odatipiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ucretDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}