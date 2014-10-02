using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WombatsAndKangaroos
{
    public partial class AddCreatureType : Form
    {
        public string newType;

        public AddCreatureType()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newType = txtCreatureType.Text;
            this.Close();
        }
    }
}
