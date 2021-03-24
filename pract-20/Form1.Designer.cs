namespace pract_20
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.GetTableByType = new System.Windows.Forms.ToolStripMenuItem();
            this.GetTableByPlace = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowAllTable = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.unitsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitsAccountDataSet = new pract_20.unitsAccountDataSet();
            this.unitsTableAdapter = new pract_20.unitsAccountDataSetTableAdapters.UnitsTableAdapter();
            this.tableAdapterManager = new pract_20.unitsAccountDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsAccountDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросыToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRecord,
            this.ChangeRecord,
            this.ShowRecord,
            this.DeleteRecord,
            this.GetTableByType,
            this.GetTableByPlace,
            this.ShowAllTable});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // AddRecord
            // 
            this.AddRecord.Name = "AddRecord";
            this.AddRecord.Size = new System.Drawing.Size(229, 22);
            this.AddRecord.Text = "Добавить";
            this.AddRecord.Click += new System.EventHandler(this.AddRecord_Click);
            // 
            // ChangeRecord
            // 
            this.ChangeRecord.Name = "ChangeRecord";
            this.ChangeRecord.Size = new System.Drawing.Size(229, 22);
            this.ChangeRecord.Text = "Изменить";
            this.ChangeRecord.Click += new System.EventHandler(this.ChangeRecord_Click);
            // 
            // ShowRecord
            // 
            this.ShowRecord.Name = "ShowRecord";
            this.ShowRecord.Size = new System.Drawing.Size(229, 22);
            this.ShowRecord.Text = "Просмотр";
            this.ShowRecord.Click += new System.EventHandler(this.ShowRecord_Click);
            // 
            // DeleteRecord
            // 
            this.DeleteRecord.Name = "DeleteRecord";
            this.DeleteRecord.Size = new System.Drawing.Size(229, 22);
            this.DeleteRecord.Text = "Удалить";
            this.DeleteRecord.Click += new System.EventHandler(this.DeleteRecord_Click);
            // 
            // GetTableByType
            // 
            this.GetTableByType.Name = "GetTableByType";
            this.GetTableByType.Size = new System.Drawing.Size(229, 22);
            this.GetTableByType.Text = "Выборка по типу изделия";
            this.GetTableByType.Click += new System.EventHandler(this.GetTableByType_Click);
            // 
            // GetTableByPlace
            // 
            this.GetTableByPlace.Name = "GetTableByPlace";
            this.GetTableByPlace.Size = new System.Drawing.Size(229, 22);
            this.GetTableByPlace.Text = "Выборка по цеху";
            this.GetTableByPlace.Click += new System.EventHandler(this.GetTableByPlace_Click);
            // 
            // ShowAllTable
            // 
            this.ShowAllTable.Name = "ShowAllTable";
            this.ShowAllTable.Size = new System.Drawing.Size(229, 22);
            this.ShowAllTable.Text = "Показать всю таблицу";
            this.ShowAllTable.Click += new System.EventHandler(this.ShowAllTable_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutUs});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.оПрограммеToolStripMenuItem.Text = "Справка";
            // 
            // AboutUs
            // 
            this.AboutUs.Name = "AboutUs";
            this.AboutUs.Size = new System.Drawing.Size(180, 22);
            this.AboutUs.Text = "О программе";
            this.AboutUs.Click += new System.EventHandler(this.AboutUs_Click);
            // 
            // unitsDataGridView
            // 
            this.unitsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitsDataGridView.AutoGenerateColumns = false;
            this.unitsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.unitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.unitsDataGridView.DataSource = this.unitsBindingSource;
            this.unitsDataGridView.Location = new System.Drawing.Point(12, 27);
            this.unitsDataGridView.Name = "unitsDataGridView";
            this.unitsDataGridView.Size = new System.Drawing.Size(1043, 515);
            this.unitsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn9.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Цех";
            this.dataGridViewTextBoxColumn1.HeaderText = "Цех";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ТипИзделия";
            this.dataGridViewTextBoxColumn2.HeaderText = "ТипИзделия";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Стоимость";
            this.dataGridViewTextBoxColumn3.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ПонедельникКолво";
            this.dataGridViewTextBoxColumn4.HeaderText = "ПонедельникКолво";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ВторникКолво";
            this.dataGridViewTextBoxColumn5.HeaderText = "ВторникКолво";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "СредаКолво";
            this.dataGridViewTextBoxColumn6.HeaderText = "СредаКолво";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ЧетвергКолво";
            this.dataGridViewTextBoxColumn7.HeaderText = "ЧетвергКолво";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ПятницаКолво";
            this.dataGridViewTextBoxColumn8.HeaderText = "ПятницаКолво";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // unitsBindingSource
            // 
            this.unitsBindingSource.DataMember = "Units";
            this.unitsBindingSource.DataSource = this.unitsAccountDataSet;
            // 
            // unitsAccountDataSet
            // 
            this.unitsAccountDataSet.DataSetName = "unitsAccountDataSet";
            this.unitsAccountDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitsTableAdapter
            // 
            this.unitsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UnitsTableAdapter = this.unitsTableAdapter;
            this.tableAdapterManager.UpdateOrder = pract_20.unitsAccountDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.unitsDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет изделий";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsAccountDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddRecord;
        private System.Windows.Forms.ToolStripMenuItem ChangeRecord;
        private System.Windows.Forms.ToolStripMenuItem ShowRecord;
        private System.Windows.Forms.ToolStripMenuItem DeleteRecord;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutUs;
        private unitsAccountDataSet unitsAccountDataSet;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private unitsAccountDataSetTableAdapters.UnitsTableAdapter unitsTableAdapter;
        private unitsAccountDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView unitsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripMenuItem GetTableByType;
        private System.Windows.Forms.ToolStripMenuItem GetTableByPlace;
        private System.Windows.Forms.ToolStripMenuItem ShowAllTable;
    }
}

