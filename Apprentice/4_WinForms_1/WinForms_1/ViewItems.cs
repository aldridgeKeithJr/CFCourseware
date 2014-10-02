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
    public partial class ViewItems : Form
    {
        private CheckedListBox checkedList;
        public List<Car> carList;
        public List<House> houseList;
        
        public ViewItems()
        {
            InitializeComponent();
            checkedList = new CheckedListBox();
            checkedList.CheckOnClick = true;
            checkedList.TabIndex = 1;
            checkedList.Size = new System.Drawing.Size(360, 280);
            checkedList.Location = new System.Drawing.Point(20, 20);
            checkedList.ThreeDCheckBoxes = true;
        }

        public ViewItems(List<Car> itemList) : this()
        {
            this.carList = itemList;
            this.Text = "Car List";

            foreach (var item in carList)
            {
                checkedList.Items.Add(item.year + " " + item.make + " " + item.model);
            }
            this.Controls.Add(checkedList);
        }

        public ViewItems(List<House> itemList) : this()
        {
            this.houseList = itemList;
            this.Text = "House List";

            foreach (var item in houseList)
            {
                checkedList.Items.Add(item.type + ", " + item.bedrooms + " bedrooms, " + item.bathrooms + " bathrooms, " + item.sqft + " square feet");
            }
            this.Controls.Add(checkedList);
        }

        private void btnDeleteCars_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedIndexCollection checkedItems = checkedList.CheckedIndices;
            
            foreach(int index in checkedItems)
            {
                checkedList.Items.RemoveAt(index);
                if (this.Text == "Car List")
                {
                    carList.RemoveAt(index);
                }
                else
                {
                    houseList.RemoveAt(index);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
