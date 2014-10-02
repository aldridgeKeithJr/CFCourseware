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
    public partial class Menu : Form
    {
        public List<CreatureType> creatureTypes;
        public List<Creature> creatures;

        public Menu()
        {
            InitializeComponent();
            creatures = new List<Creature>();
            creatureTypes = new List<CreatureType>();
            
        }

        private void btnAddCreature_Click(object sender, EventArgs e)
        {
            AddCreature ac = new AddCreature(creatures, creatureTypes);
            ac.ShowDialog();
            creatures = ac.creatures;
            ac.Dispose();
            if(creatures.Count > 0)
            {
                btnViewRemoveCreature.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCreatureTypes_Click(object sender, EventArgs e)
        {
            ViewCreatureTypes ct = new ViewCreatureTypes(creatureTypes);
            ct.ShowDialog();
            creatureTypes = ct.Types;
            ct.Dispose();
            if (creatureTypes.Count > 0)
            {
                btnAddCreature.Enabled = true;
            }
            else
            {
                btnAddCreature.Enabled = false;
            }
        }

        private void btnViewRemoveCreature_Click(object sender, EventArgs e)
        {
            ViewCreatures vc = new ViewCreatures(creatures);
            vc.ShowDialog();
            creatures = vc.Creatures;
            vc.Dispose();
            if (creatures.Count == 0)
            {
                btnViewRemoveCreature.Enabled = false;
            }
        }

    }
}
