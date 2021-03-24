namespace pract_20
{
    partial class ChangeRecord
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
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label цехLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label понедельникКолвоLabel;
            System.Windows.Forms.Label вторникКолвоLabel;
            System.Windows.Forms.Label средаКолвоLabel;
            System.Windows.Forms.Label четвергКолвоLabel;
            System.Windows.Forms.Label пятницаКолвоLabel;
            System.Windows.Forms.Label типИзделияLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.типИзделияComboBox = new System.Windows.Forms.ComboBox();
            this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitsAccountDataSet = new pract_20.unitsAccountDataSet();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.цехTextBox = new System.Windows.Forms.TextBox();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.unitsTableAdapter = new pract_20.unitsAccountDataSetTableAdapters.UnitsTableAdapter();
            this.tableAdapterManager = new pract_20.unitsAccountDataSetTableAdapters.TableAdapterManager();
            this.понедельникКолвоTextBox = new System.Windows.Forms.TextBox();
            this.вторникКолвоTextBox = new System.Windows.Forms.TextBox();
            this.средаКолвоTextBox = new System.Windows.Forms.TextBox();
            this.четвергКолвоTextBox = new System.Windows.Forms.TextBox();
            this.пятницаКолвоTextBox = new System.Windows.Forms.TextBox();
            this.Change = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            фИОLabel = new System.Windows.Forms.Label();
            цехLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            понедельникКолвоLabel = new System.Windows.Forms.Label();
            вторникКолвоLabel = new System.Windows.Forms.Label();
            средаКолвоLabel = new System.Windows.Forms.Label();
            четвергКолвоLabel = new System.Windows.Forms.Label();
            пятницаКолвоLabel = new System.Windows.Forms.Label();
            типИзделияLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsAccountDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(20, 56);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(39, 15);
            фИОLabel.TabIndex = 0;
            фИОLabel.Text = "ФИО:";
            // 
            // цехLabel
            // 
            цехLabel.AutoSize = true;
            цехLabel.Location = new System.Drawing.Point(20, 108);
            цехLabel.Name = "цехLabel";
            цехLabel.Size = new System.Drawing.Size(32, 15);
            цехLabel.TabIndex = 2;
            цехLabel.Text = "Цех:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(20, 214);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(75, 15);
            стоимостьLabel.TabIndex = 6;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // понедельникКолвоLabel
            // 
            понедельникКолвоLabel.AutoSize = true;
            понедельникКолвоLabel.Location = new System.Drawing.Point(6, 33);
            понедельникКолвоLabel.Name = "понедельникКолвоLabel";
            понедельникКолвоLabel.Size = new System.Drawing.Size(78, 13);
            понедельникКолвоLabel.TabIndex = 8;
            понедельникКолвоLabel.Text = "Понедельник:";
            // 
            // вторникКолвоLabel
            // 
            вторникКолвоLabel.AutoSize = true;
            вторникКолвоLabel.Location = new System.Drawing.Point(6, 85);
            вторникКолвоLabel.Name = "вторникКолвоLabel";
            вторникКолвоLabel.Size = new System.Drawing.Size(52, 13);
            вторникКолвоLabel.TabIndex = 10;
            вторникКолвоLabel.Text = "Вторник:";
            // 
            // средаКолвоLabel
            // 
            средаКолвоLabel.AutoSize = true;
            средаКолвоLabel.Location = new System.Drawing.Point(6, 138);
            средаКолвоLabel.Name = "средаКолвоLabel";
            средаКолвоLabel.Size = new System.Drawing.Size(41, 13);
            средаКолвоLabel.TabIndex = 12;
            средаКолвоLabel.Text = "Среда:";
            // 
            // четвергКолвоLabel
            // 
            четвергКолвоLabel.AutoSize = true;
            четвергКолвоLabel.Location = new System.Drawing.Point(6, 191);
            четвергКолвоLabel.Name = "четвергКолвоLabel";
            четвергКолвоLabel.Size = new System.Drawing.Size(52, 13);
            четвергКолвоLabel.TabIndex = 14;
            четвергКолвоLabel.Text = "Четверг:";
            // 
            // пятницаКолвоLabel
            // 
            пятницаКолвоLabel.AutoSize = true;
            пятницаКолвоLabel.Location = new System.Drawing.Point(6, 245);
            пятницаКолвоLabel.Name = "пятницаКолвоLabel";
            пятницаКолвоLabel.Size = new System.Drawing.Size(53, 13);
            пятницаКолвоLabel.TabIndex = 16;
            пятницаКолвоLabel.Text = "Пятница:";
            // 
            // типИзделияLabel
            // 
            типИзделияLabel.AutoSize = true;
            типИзделияLabel.Location = new System.Drawing.Point(20, 161);
            типИзделияLabel.Name = "типИзделияLabel";
            типИзделияLabel.Size = new System.Drawing.Size(82, 15);
            типИзделияLabel.TabIndex = 17;
            типИзделияLabel.Text = "Тип изделия:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(типИзделияLabel);
            this.groupBox1.Controls.Add(this.типИзделияComboBox);
            this.groupBox1.Controls.Add(стоимостьLabel);
            this.groupBox1.Controls.Add(this.стоимостьTextBox);
            this.groupBox1.Controls.Add(цехLabel);
            this.groupBox1.Controls.Add(this.цехTextBox);
            this.groupBox1.Controls.Add(фИОLabel);
            this.groupBox1.Controls.Add(this.фИОTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сборщик, тип и стоимость:";
            // 
            // типИзделияComboBox
            // 
            this.типИзделияComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsBindingSource, "ТипИзделия", true));
            this.типИзделияComboBox.FormattingEnabled = true;
            this.типИзделияComboBox.Items.AddRange(new object[] {
            "Стол",
            "Стул",
            "Шкаф",
            "Кресло",
            "Диван"});
            this.типИзделияComboBox.Location = new System.Drawing.Point(23, 179);
            this.типИзделияComboBox.Name = "типИзделияComboBox";
            this.типИзделияComboBox.Size = new System.Drawing.Size(210, 23);
            this.типИзделияComboBox.TabIndex = 18;
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
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsBindingSource, "Стоимость", true));
            this.стоимостьTextBox.Location = new System.Drawing.Point(23, 232);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(210, 21);
            this.стоимостьTextBox.TabIndex = 7;
            // 
            // цехTextBox
            // 
            this.цехTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsBindingSource, "Цех", true));
            this.цехTextBox.Location = new System.Drawing.Point(23, 126);
            this.цехTextBox.Name = "цехTextBox";
            this.цехTextBox.Size = new System.Drawing.Size(210, 21);
            this.цехTextBox.TabIndex = 3;
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsBindingSource, "ФИО", true));
            this.фИОTextBox.Location = new System.Drawing.Point(23, 74);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(210, 21);
            this.фИОTextBox.TabIndex = 1;
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
            // понедельникКолвоTextBox
            // 
            this.понедельникКолвоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsBindingSource, "ПонедельникКолво", true));
            this.понедельникКолвоTextBox.Location = new System.Drawing.Point(6, 51);
            this.понедельникКолвоTextBox.Name = "понедельникКолвоTextBox";
            this.понедельникКолвоTextBox.Size = new System.Drawing.Size(100, 20);
            this.понедельникКолвоTextBox.TabIndex = 9;
            // 
            // вторникКолвоTextBox
            // 
            this.вторникКолвоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsBindingSource, "ВторникКолво", true));
            this.вторникКолвоTextBox.Location = new System.Drawing.Point(6, 103);
            this.вторникКолвоTextBox.Name = "вторникКолвоTextBox";
            this.вторникКолвоTextBox.Size = new System.Drawing.Size(100, 20);
            this.вторникКолвоTextBox.TabIndex = 11;
            // 
            // средаКолвоTextBox
            // 
            this.средаКолвоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsBindingSource, "СредаКолво", true));
            this.средаКолвоTextBox.Location = new System.Drawing.Point(6, 156);
            this.средаКолвоTextBox.Name = "средаКолвоTextBox";
            this.средаКолвоTextBox.Size = new System.Drawing.Size(100, 20);
            this.средаКолвоTextBox.TabIndex = 13;
            // 
            // четвергКолвоTextBox
            // 
            this.четвергКолвоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsBindingSource, "ЧетвергКолво", true));
            this.четвергКолвоTextBox.Location = new System.Drawing.Point(6, 209);
            this.четвергКолвоTextBox.Name = "четвергКолвоTextBox";
            this.четвергКолвоTextBox.Size = new System.Drawing.Size(100, 20);
            this.четвергКолвоTextBox.TabIndex = 15;
            // 
            // пятницаКолвоTextBox
            // 
            this.пятницаКолвоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitsBindingSource, "ПятницаКолво", true));
            this.пятницаКолвоTextBox.Location = new System.Drawing.Point(6, 263);
            this.пятницаКолвоTextBox.Name = "пятницаКолвоTextBox";
            this.пятницаКолвоTextBox.Size = new System.Drawing.Size(100, 20);
            this.пятницаКолвоTextBox.TabIndex = 17;
            // 
            // Change
            // 
            this.Change.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Change.Location = new System.Drawing.Point(13, 332);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(178, 34);
            this.Change.TabIndex = 1;
            this.Change.Text = "Изменить запись";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cancel.Location = new System.Drawing.Point(244, 332);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(178, 34);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(понедельникКолвоLabel);
            this.groupBox2.Controls.Add(this.понедельникКолвоTextBox);
            this.groupBox2.Controls.Add(пятницаКолвоLabel);
            this.groupBox2.Controls.Add(this.вторникКолвоTextBox);
            this.groupBox2.Controls.Add(this.пятницаКолвоTextBox);
            this.groupBox2.Controls.Add(вторникКолвоLabel);
            this.groupBox2.Controls.Add(четвергКолвоLabel);
            this.groupBox2.Controls.Add(this.средаКолвоTextBox);
            this.groupBox2.Controls.Add(this.четвергКолвоTextBox);
            this.groupBox2.Controls.Add(средаКолвоLabel);
            this.groupBox2.Location = new System.Drawing.Point(284, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 297);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Количество изделий по дням:";
            // 
            // ChangeRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 379);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeRecord";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменить запись";
            this.Load += new System.EventHandler(this.AddRecord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitsAccountDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private unitsAccountDataSet unitsAccountDataSet;
        private System.Windows.Forms.BindingSource unitsBindingSource;
        private unitsAccountDataSetTableAdapters.UnitsTableAdapter unitsTableAdapter;
        private unitsAccountDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox типИзделияComboBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.TextBox цехTextBox;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox понедельникКолвоTextBox;
        private System.Windows.Forms.TextBox вторникКолвоTextBox;
        private System.Windows.Forms.TextBox средаКолвоTextBox;
        private System.Windows.Forms.TextBox четвергКолвоTextBox;
        private System.Windows.Forms.TextBox пятницаКолвоTextBox;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}