namespace Ex_2
{
    class ATM
    {
        public int count20;
        public int count50;
        public int count100;

      

        public void AddMoney(int count20, int count50, int count100)
        {
            this.count20 += count20;
            this.count50 += count50;
            this.count100 += count100;
        }

       

        public int MoneyinAtm()
        {
            return count100 * 100 + count50 * 50 + count20 * 20;
        }


    }




    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();
            atm.AddMoney(2, 3, 5);
            
            
        }
    }
}