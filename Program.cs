using System;

namespace ConsoleApp4
{
    public struct item
    {
        public string name;
        public int price;
        public int quantity;
        public int balance;
        public int totalBalance;

        public item(string n, int p, int q)
         {
                this.name = n;
                this.price = p;
                this.quantity = q;
                balance = 0;
                totalBalance = 0;
          }

        public void Sale(string name, int price, int quantity)
        {
            Console.WriteLine("Name: {0} \nPrice: {1} \nQuantity: {2}",name,price,quantity);
            balance = price * quantity; 
            totalBalance += balance;
            Console.WriteLine("Total Balance is {0}",totalBalance);
        }
     }
    class Program
    {
        static void Main(string[] args)
        {
            item a = new item();
            a.Sale("Lays", 20, 5);

            Console.ReadKey();
        }
    }
}
