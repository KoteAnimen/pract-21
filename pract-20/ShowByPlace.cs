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
    public partial class ShowByPlace : Form
    {
        public ShowByPlace()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            ID.resolve = false;
            Close();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if(place.Text == "")
            {
                MessageBox.Show("Укажите цех", "Ошибка");
                return;
            }
            ID.place = place.Text;
            ID.resolve = true;
            Close();
        }
    }
}
