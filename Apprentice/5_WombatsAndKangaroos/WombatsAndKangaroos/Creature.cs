using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WombatsAndKangaroos
{
    public class Creature
    {
        public int Id { get; set; }
        public string Type { get; set;}
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Weight { get; set; }

        public Creature() { }

        public Creature(int id, string type, string name, string gender, string age, string weight) : this()
        {
            this.Id = id;
            this.Type = type;
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.Weight = weight;
        }

        public String DisplayText { get { return this.ToString(); } }

        public override string ToString()
        {
            return Name + ": " + Age + " year old " + Gender + " " + Type + ", " + Weight + "Kg";
        }
    }
}
