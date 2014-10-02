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
    public partial class ViewCreatureTypes : Form
    {
        public List<CreatureType> Types;

        public ViewCreatureTypes(List<CreatureType> creatureTypes)
        {
            InitializeComponent();
            
            foreach (var item in creatureTypes)
            {
                if (!clbCreatureTypes.Items.Contains(item))
                {
                    clbCreatureTypes.Items.Add(item);
                }
            }
            Types = creatureTypes;
            this.clbCreatureTypes.DisplayMember = "Text";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCreatureType a = new AddCreatureType();
            a.ShowDialog();
            if (!clbCreatureTypes.Items.Contains(a.newType))
            {
                CreatureType ct = new CreatureType(Types.Count, a.newType);
                Types.Add(ct);
                clbCreatureTypes.Items.Add(ct);
                clbCreatureTypes.Refresh();
            }
            else
            {
                MessageBox.Show("Type already exists.", "Creature Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            a.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            List<CreatureType> checkedItems = new List<CreatureType>();
            
            foreach (CreatureType item in clbCreatureTypes.CheckedItems)
            {
                checkedItems.Add(item);
            }
            foreach(var item in checkedItems)
            {
                clbCreatureTypes.Items.Remove(item);
                Types.Remove(item);
            }
        }
    }
}
