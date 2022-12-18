using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
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


            CreditCard creditCard = new CreditCard();
            creditCard.currentAmount = 1000.30;                                     
            creditCard.accountNumber = Guid.NewGuid();
            creditCard.lastName = "Jack";
            creditCard.firstName = "Vorobey";

            CreditCard creditCard2 = new CreditCard();
            creditCard2.currentAmount = 5320.96;
            creditCard2.accountNumber = Guid.NewGuid();
            creditCard2.lastName = "Mary";
            creditCard2.firstName = "Popins";

            CreditCard creditCard3 = new CreditCard();
            creditCard3.currentAmount = 103.53;
            creditCard3.accountNumber = Guid.NewGuid();
            creditCard3.lastName = "Mikael";
            creditCard3.firstName = "O'Donel";

            Console.WriteLine($"Current amount {Strng.Format("{0:C}",creditCard.currentAmount)}.\nEnter sum for adding:");
            double sum = Int32.Parse(Console.ReadLine());
            creditCard.AddMoney(sum);

            Console.WriteLine($"Current amount {creditCard2.currentAmount}.\nEnter sum for adding:");
            double sum2 = Int32.Parse(Console.ReadLine());
            creditCard.AddMoney(sum2);

            Console.WriteLine($"Current amount {creditCard3.currentAmount}.\nEnter sum for taking:");
            double sum3 = Int32.Parse(Console.ReadLine());
            creditCard.TakeMoney(sum3);

            creditCard.CardInformation();
            creditCard2.CardInformation();
            creditCard3.CardInformation();

            Console.ReadLine();

        }
    }
    class CreditCard
    {
        public Guid accountNumber;
        public double currentAmount;
        public string firstName;
        public string lastName;

        public double AddMoney(double amount)
        {
            double increaseAmount = currentAmount + amount;
            currentAmount = increaseAmount;
            return increaseAmount;
            //Console.WriteLine(currentAmount);
        }
        public double TakeMoney(double amount)
        {
            double increaseAmount = currentAmount - amount;
            currentAmount = increaseAmount;
            return currentAmount;
            //Console.WriteLine(currentAmount);
        }
        public void CardInformation()
        {
            Console.WriteLine($"Owner: {firstName} {lastName} \nCard Number: {accountNumber} \nCurrent amount: {currentAmount}");
        }       

    }
}
