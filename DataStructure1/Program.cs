namespace DataStructure1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word to search");
            string word = Console.ReadLine();
            //orderList.Ordered(word);
            BalanceParenthesis parentheses = new BalanceParenthesis();
            parentheses.checkBalanced(word);

        }
    }
}