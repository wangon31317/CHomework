namespace Homework03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個有意義的英文敘述字串，計算其個別單字數量(不區分大小寫)：");
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("請輸入有效的字串！");
                return;
            }

            string lowerInput = input.ToLower();

            var words = lowerInput.Split(' ');
            var result = words
                .GroupBy(w => w)
                .Select(g => new { Word = g.Key, Count = g.Count() });

            foreach (var word in result)
            {
                Console.WriteLine($"{word.Word} : {word.Count}");
            }









        }
    }
}
