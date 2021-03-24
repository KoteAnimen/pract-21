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
    public partial class ShowRecord : Form
    {
        public ShowRecord()
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
