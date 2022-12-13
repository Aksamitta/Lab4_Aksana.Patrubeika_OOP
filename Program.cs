using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Aksana.Patrubeika_OOP
{
    class Phone
    {
        public long number;
        public string model;
        public double weight;
        public string name;

        public void ReceiveCall()
        {
            Console.WriteLine($"Calling: {name}");
        }

        public void GetNumber()
        {
            Console.WriteLine(number);
        }    

        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            

            
            Phone firstUser = new Phone();            
            firstUser.number = 1111;
            firstUser.model = "Samsung";
            firstUser.weight = 102.5;
            firstUser.name = "Jack";

            Phone secondUser = new Phone();
            secondUser.number = 2222;
            secondUser.model = "Apple";
            secondUser.weight = 130.5;
            secondUser.name = "Barbara";

            Phone thirdUser = new Phone();
            thirdUser.number = 3333;
            thirdUser.model = "Xiaomi";
            thirdUser.weight = 100.3;
            thirdUser.name = "Bob";            

            Console.WriteLine($"Number: {firstUser.number} \nModel: {firstUser.model} \nWeight: {firstUser.weight}\n");
            Console.WriteLine($"Number: {secondUser.number} \nModel: {secondUser.model} \nWeight: {secondUser.weight}\n");
            Console.WriteLine($"Number: {thirdUser.number} \nModel: {thirdUser.model} \nWeight: {thirdUser.weight}\n");


            firstUser.ReceiveCall();
            firstUser.GetNumber();            

            secondUser.ReceiveCall();
            secondUser.GetNumber();

            thirdUser.ReceiveCall();
            thirdUser.GetNumber();
            
            ReceiveCall(firstUser.name, firstUser.number);
            ReceiveCall(secondUser.name, secondUser.number);
            ReceiveCall(thirdUser.name, thirdUser.number);
            
            SendMessage(firstUser.number, secondUser.number, thirdUser.number);

            Console.ReadLine();
        }

        public static void ReceiveCall(string name, long number)
        {
            Console.WriteLine($"Calling: {name} \t{number}");
        }

        public static void SendMessage(params long[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number}\t");
            }

        }
    }
}
