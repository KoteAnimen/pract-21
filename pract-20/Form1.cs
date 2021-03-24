using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract_20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void unitsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.unitsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.unitsAccountDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SingIn sing = new SingIn();
            sing.ShowDialog(this);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "unitsAccountDataSet.Units". При необходимости она может быть перемещена или удалена.
            this.unitsTableAdapter.Fill(this.unitsAccountDataSet.Units);

        }

        private void AddRecord_Click(object sender, EventArgs e)
        {
            AddRecord add = new AddRecord();
            add.ShowDialog();
            this.unitsTableAdapter.Fill(this.unitsAccountDataSet.Units);
        }

        private void ChangeRecord_Click(object sender, EventArgs e)
        {
            ID.id = unitsDataGridView[0, unitsDataGridView.CurrentRow.Index].Value.ToString();            
            ChangeRecord change = new ChangeRecord();
            change.ShowDialog();
            this.unitsTableAdapter.Fill(this.unitsAccountDataSet.Units);
        }

        private void ShowRecord_Click(object sender, EventArgs e)
        {
            ID.id = unitsDataGridView[0, unitsDataGridView.CurrentRow.Index].Value.ToString();
            ShowRecord show = new ShowRecord();
            show.ShowDialog();
        }

        private void DeleteRecord_Click(object sender, EventArgs e)
        {
            DialogResult result;
            try
            {
                result = MessageBox.Show("Вы действительно хотите удалить запись из базы данных?", "Удаление записи", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    unitsBindingSource.RemoveCurrent();
                    unitsTableAdapter.Update(this.unitsAccountDataSet.Units);
                }
            }
            catch
            {
                MessageBox.Show("Таблица пуста", "Ошибка");
                return;
            }
            
        }

        private void GetTableByType_Click(object sender, EventArgs e)
        {
            ShowByType show = new ShowByType();
            show.ShowDialog();
            if (ID.resolve == true)
            {
                this.unitsTableAdapter.FillByType(this.unitsAccountDataSet.Units, ID.type);
            }           
        }

        private void GetTableByPlace_Click(object sender, EventArgs e)
        {
            ShowByPlace show = new ShowByPlace();
            show.ShowDialog();
            if (ID.resolve == true)
            {
                this.unitsTableAdapter.FillByPlace(this.unitsAccountDataSet.Units, ID.place);
            }            
        }

        private void ShowAllTable_Click(object sender, EventArgs e)
        {
            this.unitsTableAdapter.Fill(this.unitsAccountDataSet.Units);
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Филяк, ИСП-31, вариант 1. Учет изделий, собранных в цехе за неделю. База данных должна содержать следующую информацию: фамилию, имя, отчество сборщика, количество изготовленных изделий за каждый день недели раздельно, название цеха, а также тип изделия и его стоимость.", "О программе");
        }
    }
    public static class ID
    {
        public static string id;
        public static string type;
        public static string place;
        public static bool resolve;
    }
}
