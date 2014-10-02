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
    public partial class ViewCreatures : Form
    {
        public List<Creature> Creatures;

        public ViewCreatures()
        {
            InitializeComponent();
            this.clbAllCreatures.DisplayMember = "DisplayText";            
        }

        public ViewCreatures(List<Creature> creatures) : this()
        {
            Creatures = creatures;
            foreach (var item in creatures)
            {
                clbAllCreatures.Items.Add(item);
            }
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<Creature> tempList = new List<Creature>();

            foreach (Creature item in clbAllCreatures.CheckedItems)
            {
                tempList.Add(item);
            }

            foreach (var item in tempList)
            {
                clbAllCreatures.Items.Remove(item);
                Creatures.Remove((Creature)item);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
