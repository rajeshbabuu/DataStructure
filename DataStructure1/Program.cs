namespace DataStructure1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordered Linkedlist");

            OrderList orderList = new OrderList();

            Console.WriteLine("Enter word to search");
            string word = Console.ReadLine();
            orderList.Ordered(word);
        }
    }
}