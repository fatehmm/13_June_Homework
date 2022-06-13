using System;

namespace MilkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hansi uzunluqda sud listi yaratmaq isteyirsiniz?....");
            string consoleQueryStr;
            
                consoleQueryStr = Console.ReadLine();

            Milk[] milks;
            InputElemnt:

            bool checkPrs = int.TryParse(consoleQueryStr, out int consoleQuery);

            if (checkPrs)
            {
               milks = new Milk[consoleQuery];
            }
            else
            {
                goto InputElemnt;
            }
            for (int i = 0; i < milks.Length; i++)
            {
                Console.Write("Sudun adini daxil ele.....");
                string milkName = Console.ReadLine();

                Console.Write("Sudun yag faizini daxil ele.....");
                string fatPctStr = Console.ReadLine();

                Console.Write("Sudun qiymetini daxil ele......");
                string priceStr = Console.ReadLine();

                bool checkPercent = double.TryParse(fatPctStr, out double fatPct);
                bool checkPrice = double.TryParse(priceStr, out double price);

                if (checkPercent == true && checkPrice == true)
                {
                    Milk milk = new Milk()
                    {
                        Name = milkName,
                        FatPercent = fatPct,
                        Price = price
                    };

                    milks[i] = milk;
                }
            }

            foreach (var item in milks)
            {
                Console.WriteLine($"{item.Name} sudu, {item.FatPercent}% yagliliqdadir, Qiymeti - {item.Price} AZN");
            }
            

        }
    }
}

