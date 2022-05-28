
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Logger and payment test
            //var result = $"Factory was implemented at {DateTime.Now}";
            lLogger cLogger = LoggerFactory.CreateLogger(LoggerFactory.LoggerType.Console);
            lLogger fLogger = LoggerFactory.CreateLogger(LoggerFactory.LoggerType.File);
            lLogger dLogger = LoggerFactory.CreateLogger(LoggerFactory.LoggerType.Database);
            lLogger rLogger = LoggerFactory.CreateLogger(LoggerFactory.LoggerType.Reservation);
            Payment lPayment = new LocalPayment("Filip", 1234213412341234, 1234, 16, fLogger);
            Payment oPayment = new OnlinePayment("Filip", 1234213412341234, 10, 22, 123, 23, cLogger);
            Payment cPayment = new CashPayment(1234, 16, cLogger);
            Table testTable = new Table00002("1234", "123", "123", "123", "123", true);
            Console.WriteLine("Table data check: ");
            Console.WriteLine("ID: " + testTable.Id);
            Console.WriteLine("Name: " + testTable.Name);
            Console.WriteLine("Desc: " + testTable.Desc);
            Console.WriteLine("Res: " + testTable.Res);
            Console.WriteLine("Size: " + testTable.Size);
            Console.WriteLine("Booked: " + testTable.Booked);
            testTable.BookTable("21:50:20", "29/04/2018" , rLogger);
            //char[] delimiterChars = { '(', ')' };
            //String[] data = null;
            //int counter = 0;
            //foreach (string line in System.IO.File.ReadLines(@"C:\\Users\\filip\\source\\repos\\ArchitectureProject\\ArchitectureProject\\Table00001.txt"))
            //{
            //    System.Console.WriteLine(line);
            //    data = line.Split(delimiterChars);
            //    counter++;
            //}

            //foreach (String str in data)
            //{
            //    System.Console.WriteLine(str);
            //}

            //System.Console.WriteLine("There were {0} lines.", counter);
            //// Suspend the screen.  
            //System.Console.ReadLine();


            //lPayment.validatePayment();
            //oPayment.validatePayment();
            //cPayment.validatePayment();
            //rLogger.Log("asdasd");
            //DateTime dateTime = DateTime.UtcNow.Date;
            //Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));

            //string text = System.IO.File.ReadAllText("C:\\Users\\filip\\source\\repos\\ArchitectureProject\\ArchitectureProject\\Table2.txt");
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", text);


            //Provisional Menu
            MenuItem fries = new MenuItem("1", "Fries", "Our delicious cripsy fries", 5.99, "true", "380", "test_path");
            MenuItem brownie = new MenuItem("2", "Brownie", "Fresh brownie with moltem chocolate inside", 4.00, "true", "730", "test_path");
            MenuItem pizza = new MenuItem("3", "Pizza", "Pizza Carbonara", 18.20, "false", "1420", "test_path");
            MenuItem pasta = new MenuItem("4", "Pasta", "Pasta with prawns and our special souce", 21.00, "false", "1003", "test_path");
            MenuItem coffee = new MenuItem("5", "Coffee", "Freshly brewed coffee", 5.00, "true", "24", "test_path");
            MenuItem juice = new MenuItem("6", "Juice", "Orange juice squeezed this morning", 7.00, "true", "142", "test_path");

            List<MenuItem> allItems = new List<MenuItem>();
            allItems.Add(fries);
            allItems.Add(brownie);
            allItems.Add(pizza);
            allItems.Add(pasta);
            allItems.Add(coffee);
            allItems.Add(juice);
            //End Menu

            //Customer and order test along with logging
            Customer customer = new Customer("0001", "Filip");
            //Creating online order
            Order cusOrder = customer.createOrder("1", oPayment);

            ////Provisional command menu
            //String selected = "";
            //String command = "menu";
            //bool created = false;
            //int idCount = 2;



            //while (command != "exit")
            //{

            //    if (command == "menu")
            //    {
            //        Console.WriteLine("Please select:");
            //        Console.WriteLine("1.Create new order - command create.");
            //        Console.WriteLine("2.View your existing orders  - command view.");
            //        command = Console.ReadLine();
            //    }
            //    if (command == "view")
            //    {
            //        int idIndex = 0;
            //        Console.WriteLine("Please select by typing in order ID or type return to come back to main menu:");
            //        foreach (Order o in customer.Orders)
            //        {
            //            Console.WriteLine($"{idIndex}.Order ID: {o.Id}");
            //            idIndex++;
            //        }
            //        selected = Console.ReadLine();
            //        if (selected == "return")
            //        {
            //            command = "menu";
            //        }
            //        else
            //        {
            //            int orderIndex = 0;
            //            foreach (MenuItem menuItem in customer.getOrder(selected).Items)
            //            {
            //                orderIndex++;
            //                Console.WriteLine($"{orderIndex}.{menuItem.Name}");
            //            }
            //        }
            //    }

            //    if (command == "create")
            //    {
            //        if(!created)
            //        {
            //            Order newOrder = customer.createOrder($"{idCount}", oPayment);
            //        }
            //        created = true;
            //        idCount++;
            //        String choice = "";
            //        int i = 0;
            //        foreach (MenuItem x in allItems)
            //        {
            //            i++;
            //            Console.WriteLine(i + "." + x.Name + " - " + x.Desc);
            //        }
            //        Console.WriteLine("Please provide number of selected item or type return to end.");
            //        choice = Console.ReadLine();
            //        if(choice == "return")
            //        {
            //            created = false;
            //            command = "menu";
            //        }
            //        else
            //        {
            //            newOrder.addItem(allItems[Int32.Parse(choice) - 1]);
            //            Console.WriteLine("Your order so far:");
            //            int j = 0;
            //            foreach (MenuItem x in cusOrder.Items)
            //            {
            //                j++;
            //                Console.WriteLine(j + "." + x.Name + " - " + x.Desc);
            //            }
            //            Console.WriteLine();
            //            Console.WriteLine();
            //        }
            //    }
            //}






            Console.ReadLine(); 

        }
    }

}
