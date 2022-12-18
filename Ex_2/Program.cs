namespace Ex_2
{
    class ATM
    {
        public int count20;
        public int count50;
        public int count100;
        public int result;
        public int money;
        public ATM(int count20, int count50, int count100)
        {
            this.count20 = count20;
            this.count50 = count50;
            this.count100 = count100;
            
        }

        public void AddMoney(int count20, int count50, int count100)
        {
            this.count20 += count20;
            this.count50 += count50;
            this.count100 += count100;
        }
        public int MoneyinAtm()
        {
            int result = count100 * 100 + count50 * 50 + count20 * 20;
            return result;
        }

        public void CashOut(int money)
        {
            if (money > MoneyinAtm())
            {
                Console.WriteLine("Not enought money");

            }
            else
            {
                Console.WriteLine("Done!");
                

            }

        }


    }




    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM(1,2,3);
            atm.AddMoney(2, 3, 20);  
            Console.WriteLine("Total : \t" + atm.MoneyinAtm());
            Console.WriteLine("How much do you want cashout? ");
            atm.CashOut(Convert.ToInt32(Console.ReadLine()));
            
           



        }
    }
}