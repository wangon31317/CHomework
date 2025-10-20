namespace Homework06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入你的年收入：");
            bool isDecimal = decimal.TryParse(Console.ReadLine(), out decimal salary);
            if (isDecimal == false)
            {
                Console.WriteLine("請輸入正確數字！");
                return;
            }
            else if (salary < 0)
            {
                Console.WriteLine("收入不得為負！");
                return;
            }


            decimal tax = Math.Round(TaxCalculate.CalculateTax(salary), 2);
            decimal avgTaxRate = Math.Round((tax / salary) * 100m, 2); 
            Console.WriteLine($"您要繳的稅金為{tax:N2} 元，平均稅率為{avgTaxRate}%，國庫感謝您的貢獻！");



        }
    }
}
