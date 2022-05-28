using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class MenuItem
    {

        private string id;
        private string name;
        private string desc;
        private double price;
        private string veg;
        private string cal;
        private string img;

        public MenuItem(String Id, String Name, String Desc, double Price, String Veg, String Cal, String Img)
        {
            this.Id = Id;
            this.Name = Name;
            this.Desc = Desc;
            this.Price = Price;
            this.Veg = Veg;
            this.Cal = Cal;
            this.Img = Img;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }
        public double Price { get => price; set => price = value; }
        public string Veg { get => veg; set => veg = value; }
        public string Cal { get => cal; set => cal = value; }
        public string Img { get => img; set => img = value; }
    }
}
