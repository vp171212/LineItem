using LineItemList.Model;

namespace LineItemList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<LineItem> items = new List<LineItem>
            {
                new LineItem(101,"Milkbikies",2,50),
                 new LineItem(102,"Dairy Milk",2,100),
                  new LineItem(103,"Book",3,100)
            };
            PrintItems(items);
        }

        private static void PrintItems(List<LineItem> items)
        {
            double total = 0;
            Console.WriteLine("================Order Details================");
            foreach (LineItem item in items)
            {
                Console.WriteLine(item);
                total+=item.ItemCost;
            }
            Console.WriteLine("================================");
            Console.WriteLine("Total Cart Cost: "+ total);
        }
    }
}