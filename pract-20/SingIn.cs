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
    public partial class SingIn : Form
    {
        public SingIn()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Owner.Close();
        }

        private void Sing_Click(object sender, EventArgs e)
        {
            this.авторизацияTableAdapter.FillBy(this.unitsAccountDataSet.Авторизация, login.Text, password.Text);
            int count = this.unitsAccountDataSet.Авторизация.Rows.Count;
            if(count == 1)
            {
                data.access = this.unitsAccountDataSet.Авторизация.Rows[0][3].ToString();
                data.login = true;
                data.lastName = this.unitsAccountDataSet.Авторизация.Rows[0][5].ToString();
                data.firstName = this.unitsAccountDataSet.Авторизация.Rows[0][6].ToString();
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка авторизации");
                login.Focus();
            }
        }

        private void авторизацияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.авторизацияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.unitsAccountDataSet);

        }

        private void SingIn_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "unitsAccountDataSet.Авторизация". При необходимости она может быть перемещена или удалена.
            this.авторизацияTableAdapter.Fill(this.unitsAccountDataSet.Авторизация);

        }
    }
}
