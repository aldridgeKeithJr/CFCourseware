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
    public partial class Menu : Form
    {
        List<Car> carList = new List<Car>();
        List<House> houseList = new List<House>();

        public Menu()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            AddCar c = new AddCar(carList);
            c.Show();
            carList = c.cars;
        }

        private void btnViewAllCars_Click(object sender, EventArgs e)
        {
            ViewItems v = new ViewItems(carList);
            v.Show();
            carList = v.carList;
        }

        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            AddHouse h = new AddHouse(houseList);
            h.Show();
            houseList = h.houses;
        }

        private void btnViewAllHouses_Click(object sender, EventArgs e)
        {
            ViewItems v = new ViewItems(houseList);
            v.Show();
            houseList = v.houseList;
        }
    }
}
