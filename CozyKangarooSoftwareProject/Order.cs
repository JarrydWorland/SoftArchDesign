using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class Order
    {
        private string id;
        private List<MenuItem> items;
        private Payment payment;
        private bool finished;
        private bool delivered;
        private int time;
        public Order(String Id, Payment payment, int time)
        {
            this.id = Id;
            this.payment = payment;
            this.finished = false;
            this.delivered = false;
            this.time = time;
            items = new List<MenuItem>();
        }


        public double totalSum()
        {
            double sum = 0;
            foreach(MenuItem item in items)
            {
                sum += item.Price;
            }
            return sum;
        }

        public Boolean removeItem(MenuItem item)
        {
            if(items.Contains(item))
            {
                items.Remove(item);
                return true;
            }
            return false;
        }

        public void addItem(MenuItem item)
        {
            Items.Add(item);
        }

        public string Id { get => id; set => id = value; }
        public List<MenuItem> Items { get => items; set => items = value; }
        public Payment Payment { get => payment; set => payment = value; }
        public int Time { get => time; set => time = value; }
        public bool Finished { get => finished; set => finished = value; }
        public bool Delivered { get => delivered; set => delivered = value; }
    }
}
