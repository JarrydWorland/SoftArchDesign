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
            

        public Table()
        {
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Res { get => res; set => res = value; }
        public string Size { get => size; set => size = value; }
        public bool Booked { get => booked; set => booked = value; }
    }
}
