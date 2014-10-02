using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_1
{
    public partial class AddCar : Form
    {
        public List<Car> cars;

        public AddCar(List<Car> carList)
        {
            cars = carList;
            InitializeComponent();
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.Items.Add("");
            for (int i = DateTime.Now.Year + 1; i >= 1900; i--)
            {
                cmbYear.Items.Add(i.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMake.Text != "" && txtModel.Text != "")
            {
                cars.Add(new Car(cmbYear.Text, txtMake.Text, txtModel.Text));
                cmbYear.SelectedIndex = 0;
                txtMake.Text = "";
                txtModel.Text = "";
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Add Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            if (txtMake.Text != "" && txtModel.Text != "")
            {
                cars.Add(new Car(cmbYear.Text, txtMake.Text, txtModel.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Add Car", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
