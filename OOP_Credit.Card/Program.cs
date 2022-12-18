using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Credit.Card
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1.Создать класс CreditCard c полями номер счета, текущая  сумма на счету.
                Добавьте метод, который позволяет начислять сумму на кредитную карточку. 
                Добавьте метод, который позволяет снимать с карточки некоторую сумму. Добавьте метод, который выводит текущую информацию о карточке.
                Тестовый сценарий для проверки: 
                Положите деньги на первые две карточки и снимите с третьей. Выведите на экран текущее состояние всех трех карточек.
                            */
            var card1 = new CreditCard("4256 ggtd 5896 drfg", 1000.36);
            var card2 = new CreditCard("5236 gfgt 4125 ddfr", 5036.23);
            var card3 = new CreditCard("7459 4125 6325 4125", 123.2);

            Console.WriteLine($"Current amount {card1.currentAmount}.\nEnter sum for adding:");
            double sum = Int32.Parse(Console.ReadLine());
            card1.AddMoney(sum);
            Console.WriteLine($"Current amount {card2.currentAmount}.\nEnter sum for adding:");
            double sum2 = Int32.Parse(Console.ReadLine());
            card2.AddMoney(sum2);
            Console.WriteLine($"Current amount {card3.currentAmount}.\nEnter sum for adding:");
            double sum3 = Int32.Parse(Console.ReadLine());
            card3.TakingMoney(sum3);

            card1.CardInfo();
            card2.CardInfo();
            card3.CardInfo();

            Console.ReadLine();

        }
    }

    public class CreditCard
    {
        public string accountNumber;
        public double currentAmount;

        public CreditCard(string accountNumber, double currentAmount)
        {
            this.accountNumber = accountNumber;
            this.currentAmount = currentAmount;
        }

        public void AddMoney(double amount)
        {
            this.currentAmount += amount;
        }

        public void TakingMoney(double amount)
        {
            this.currentAmount -= amount;
        }

        public void CardInfo()
        {
            Console.WriteLine($"Card number: {accountNumber} \tCard Amount: {currentAmount}");
        }
    }
}
