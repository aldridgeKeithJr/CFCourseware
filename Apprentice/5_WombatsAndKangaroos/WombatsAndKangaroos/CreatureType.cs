using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WombatsAndKangaroos
{
    public class CreatureType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

        public String Text { get { return this.ToString(); } }

        public CreatureType(int id, string typename)
        {
            this.Id = id;
            this.TypeName = typename;
        }

        public override string ToString()
        {
            return this.TypeName;
        }
    }
}
