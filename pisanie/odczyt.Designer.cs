namespace WindowsFormsApplication1
{
    partial class odczyt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odczyt));
            this.bazadanychDataSet = new WindowsFormsApplication1.bazadanychDataSet();
            this.wynikiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wynikiTableAdapter = new WindowsFormsApplication1.bazadanychDataSetTableAdapters.wynikiTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication1.bazadanychDataSetTableAdapters.TableAdapterManager();
            this.wynikiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wyczyscbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bazadanychDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bazadanychDataSet
            // 
            this.bazadanychDataSet.DataSetName = "bazadanychDataSet";
            this.bazadanychDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wynikiBindingSource
            // 
            this.wynikiBindingSource.DataMember = "wyniki";
            this.wynikiBindingSource.DataSource = this.bazadanychDataSet;
            // 
            // wynikiTableAdapter
            // 
            this.wynikiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication1.bazadanychDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.wynikiTableAdapter = this.wynikiTableAdapter;
            // 
            // wynikiDataGridView
            // 
            this.wynikiDataGridView.AllowUserToAddRows = false;
            this.wynikiDataGridView.AllowUserToDeleteRows = false;
            this.wynikiDataGridView.AutoGenerateColumns = false;
            this.wynikiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wynikiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.wynikiDataGridView.DataSource = this.wynikiBindingSource;
            this.wynikiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wynikiDataGridView.Location = new System.Drawing.Point(0, 0);
            this.wynikiDataGridView.Name = "wynikiDataGridView";
            this.wynikiDataGridView.ReadOnly = true;
            this.wynikiDataGridView.Size = new System.Drawing.Size(445, 346);
            this.wynikiDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nick";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nick";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Wynik";
            this.dataGridViewTextBoxColumn2.HeaderText = "Wynik";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Czas";
            this.dataGridViewTextBoxColumn3.HeaderText = "Czas";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "WPS";
            this.dataGridViewTextBoxColumn4.HeaderText = "WPS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // wyczyscbutton
            // 
            this.wyczyscbutton.Location = new System.Drawing.Point(358, 311);
            this.wyczyscbutton.Name = "wyczyscbutton";
            this.wyczyscbutton.Size = new System.Drawing.Size(75, 23);
            this.wyczyscbutton.TabIndex = 2;
            this.wyczyscbutton.Text = "Wyczyść";
            this.wyczyscbutton.UseVisualStyleBackColor = true;
            this.wyczyscbutton.Click += new System.EventHandler(this.wyczyscbutton_Click);
            // 
            // odczyt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 346);
            this.Controls.Add(this.wyczyscbutton);
            this.Controls.Add(this.wynikiDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "odczyt";
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.odczyt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazadanychDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private bazadanychDataSet bazadanychDataSet;
        private System.Windows.Forms.BindingSource wynikiBindingSource;
        private bazadanychDataSetTableAdapters.wynikiTableAdapter wynikiTableAdapter;
        private bazadanychDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView wynikiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button wyczyscbutton;
    }
}