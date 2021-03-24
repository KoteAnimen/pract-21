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
    public partial class AddRecord : Form
    {
        public AddRecord()
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
            this.unitsTableAdapter.Fill(this.unitsAccountDataSet.Units);
            this.unitsBindingSource.AddNew();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int sale;
            if(фИОTextBox.Text == "")
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
                unitsTableAdapter.Insert(цехTextBox.Text, типИзделияComboBox.Text, sale, Convert.ToInt16(понедельникКолвоTextBox.Text), Convert.ToInt16(вторникКолвоTextBox.Text), Convert.ToInt16(средаКолвоTextBox.Text), Convert.ToInt16(четвергКолвоTextBox.Text), Convert.ToInt16(пятницаКолвоTextBox.Text), фИОTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Неверный формат количества изделий", "Ошибка");
                return;
            }
            Close();
        }
    }
}
