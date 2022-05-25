using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class Table
    {

        private string id;
        private string name;
        private string desc;
        private string res;
        private string size;
        private bool booked;
            

        public Table(String Id, String Size, String Name, String Desc, String Res, bool Booked)
        {
            this.booked = Booked;  
            this.id = Id;
            this.name = Name;
            this.desc = Desc;
            this.res = Res;
            this.size = Size;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Res { get => res; set => res = value; }
        public string Size { get => size; set => size = value; }
        public bool Booked { get => booked; set => booked = value; }
    }
}
