using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interface
{
    public interface ITransactions
    {
        void showTransaction();
        double getAmount();
    }

    public class Transaction : ITransactions 
    {
        private string tCode;
        private string date;
        private double amount;

        public Transaction()
        {
            tCode = "";
            date = "";
            amount = 0.0;
        }

        public Transaction(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public double getAmount()
        {
            return amount;
        }

        public void showTransaction()
        { 
            Console.WriteLine("tcode是{0}",tCode);
            Console.WriteLine("date是{0}", date);
            Console.WriteLine("amount是{0}", amount);
        }
    }

    class Tester
    {
  

        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("001", "2018/07/16", 200);
            Transaction t2 = new Transaction("004", "2018/07/20", 300);
            t1.showTransaction();
            t2.showTransaction();
            Console.ReadKey();
        }
    }
}
