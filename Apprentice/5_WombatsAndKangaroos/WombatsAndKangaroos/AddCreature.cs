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
    public partial class AddCreature : Form
    {
        public List<Creature> creatures;

        public AddCreature()
        {
            InitializeComponent();
        }
        
        public AddCreature(List<Creature> c, List<CreatureType> ct) : this()
        {
            creatures = c;
            if (ct != null)
            {
                foreach (var item in ct)
                {
                    cbType.Items.Add(item);
                }
            }
            cbType.DisplayMember = "Text";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            creatures.Add(new Creature(creatures.Count, cbType.Text, txtName.Text, cbGender.Text, txtAge.Text, txtWeight.Text));
            txtName.Text = "";
            txtAge.Text = "";
            txtWeight.Text = "";
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            creatures.Add(new Creature(creatures.Count, cbType.Text, txtName.Text, cbGender.Text, txtAge.Text, txtWeight.Text));
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
