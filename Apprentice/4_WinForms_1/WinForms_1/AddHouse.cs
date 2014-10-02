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
    public partial class AddHouse : Form
    {
        public List<House> houses;

        public AddHouse(List<House> houseList)
        {
            houses = houseList;
            InitializeComponent();
            cmbBeds.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBeds.Items.Add("");
            cmbBaths.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBaths.Items.Add("");
            cmbPropType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPropType.Items.Add("");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbBeds.Text != "" && cmbBaths.Text != "" && txtSqft.Text != "")
            {
                decimal result;
                if (WinForms_1.Validate.IsNumber(txtSqft.Text, out result))
                {
                    houses.Add(new House(cmbBeds.Text, cmbBaths.Text, txtSqft.Text, cmbPropType.Text));
                    cmbBaths.SelectedIndex = 0;
                    cmbBeds.SelectedIndex = 0;
                    cmbPropType.SelectedIndex = 0;
                    txtSqft.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid square footage entry", "Add House", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSqft.Text = "";
                    txtSqft.Focus();
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Add House", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            if (cmbBeds.Text != "" && cmbBaths.Text != "" && txtSqft.Text != "")
            {
                decimal result;
                if (WinForms_1.Validate.IsNumber(txtSqft.Text, out result))
                {
                    houses.Add(new House(cmbBeds.Text, cmbBaths.Text, txtSqft.Text, cmbPropType.Text));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid square footage entry", "Add House", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSqft.Text = "";
                    txtSqft.Focus();
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled.", "Add House", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
