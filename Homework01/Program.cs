namespace Homework01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個整數 (需大於90)：");
            bool isParsed = int.TryParse(Console.ReadLine(), out int maxNumber);
            if (isParsed == false)
            {
                Console.WriteLine("請輸入一個整數！！");
                return;
            }


            if (maxNumber <= 90)
            {
                Console.WriteLine("請正確輸入一個大於90的數字！");
                return;
            }

            for (int i = 1; i <= maxNumber; i++)
            {

                if (i % 15 == 0)
                {
                    Console.WriteLine("Dann");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Build");
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("School");
                }

                else
                {
                    Console.WriteLine(i);
                }


            }

            Console.ReadLine();
        }

    }


}

