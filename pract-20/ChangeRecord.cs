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
    public partial class ChangeRecord : Form
    {
        public ChangeRecord()
        {
            InitializeComponent();
        }

        private void unitsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.unitsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.unitsAccountDataSet);

        }

        private void AddRecord_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "unitsAccountDataSet.Units". При необходимости она может быть перемещена или удалена.
            this.unitsTableAdapter.FillBy(this.unitsAccountDataSet.Units, ID.id);
            фИОTextBox.Text = unitsAccountDataSet.Units.Rows[0][8].ToString();
            цехTextBox.Text = unitsAccountDataSet.Units.Rows[0][0].ToString();
            типИзделияComboBox.Text = unitsAccountDataSet.Units.Rows[0][1].ToString();
            стоимостьTextBox.Text = unitsAccountDataSet.Units.Rows[0][2].ToString();
            понедельникКолвоTextBox.Text = unitsAccountDataSet.Units.Rows[0][3].ToString();
            вторникКолвоTextBox.Text = unitsAccountDataSet.Units.Rows[0][4].ToString();
            средаКолвоTextBox.Text = unitsAccountDataSet.Units.Rows[0][5].ToString();
            четвергКолвоTextBox.Text = unitsAccountDataSet.Units.Rows[0][6].ToString();
            пятницаКолвоTextBox.Text = unitsAccountDataSet.Units.Rows[0][7].ToString();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            int sale;
            if (фИОTextBox.Text == "")
            {
                MessageBox.Show("Введите фамилию, имя, отчество сборщика", "Ошибка");
                return;
            }
            bool f = Int32.TryParse(стоимостьTextBox.Text, out sale);
            if (!f)
            {
                MessageBox.Show("Неверный формат стоимости", "Ошибка");
                return;
            }
            try
            {
                unitsTableAdapter.UpdateRecord(цехTextBox.Text, типИзделияComboBox.Text, sale, Convert.ToInt16(понедельникКолвоTextBox.Text), Convert.ToInt16(вторникКолвоTextBox.Text), Convert.ToInt16(средаКолвоTextBox.Text), Convert.ToInt16(четвергКолвоTextBox.Text), Convert.ToInt16(пятницаКолвоTextBox.Text), фИОTextBox.Text, ID.id);
            }
            catch
            {
                MessageBox.Show("Неверный формат количества изделий", "Ошибка");
                return;
            }
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
