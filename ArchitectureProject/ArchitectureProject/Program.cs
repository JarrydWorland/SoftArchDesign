using CozyKangarooSoftwareProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Mediator test

            Customer cus = new Customer("123", "test");
            Order ord = new Order("321", true);
            new ConcreteMediator(cus, ord);

            Console.WriteLine("Client triggets operation A.");
            cus.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation B.");
            ord.DoD();

            Console.ReadLine();


            //test end


            MenuItem fries = new MenuItem("1", "Fries", "Our delicious cripsy fries", "$5.99", "true", "380", "test_path");
            MenuItem brownie = new MenuItem("2", "Brownie", "Fresh brownie with moltem chocolate inside", "$4.00", "true", "730", "test_path");
            MenuItem pizza = new MenuItem("3", "Pizza", "Pizza Carbonara", "$18.20", "false", "1420", "test_path");
            MenuItem pasta = new MenuItem("4", "Pasta", "Pasta with prawns and our special souce", "$21.00", "false", "1003", "test_path");
            MenuItem coffee = new MenuItem("5", "Coffee", "Freshly brewed coffee", "$5.00", "true", "5", "test_path");
            MenuItem juice = new MenuItem("6", "Juice", "Orange juice squeezed this morning", "$7.00", "true", "142", "test_path");

            List<MenuItem> allItems = new List<MenuItem>();
            allItems.Add(fries);
            allItems.Add(brownie);
            allItems.Add(pizza);
            allItems.Add(pasta);
            allItems.Add(coffee);
            allItems.Add(juice);

            Customer customer1 = new Customer("123", "test");
            customer1.createOrder("1", false);
 
            String command = "";
            while(command != "exit")
            {
                int i = 0;
                foreach (MenuItem x in allItems)
                {
                    i++;
                    Console.WriteLine(i + "." + x.Name + " - " + x.Desc);
                }

                Console.WriteLine("Please provide number of selectd item or type exit to end.");
                command = Console.ReadLine();
                customer1.addToOrder(allItems[Int32.Parse(command) - 1]);

                Console.WriteLine("Your order so far:");
                int j = 0;
                foreach (MenuItem x in customer1.showOrder().Items)
                {
                    j++;
                    Console.WriteLine(j + "." + x.Name + " - " + x.Desc);
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            Payment p = Payment.GetInstance();
            customer1.finishOrder(p);

            String response = Console.ReadLine();
            
        }
    }
}
