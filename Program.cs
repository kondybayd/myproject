using System.Text;

namespace ConsoleGitTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();


            /*Console.WriteLine("Калькулятор!");
            Console.Write("num1:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("num2:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Что делаем(+,-,*,/) - ");
            char symbol = Convert.ToChar(Console.ReadLine());
            double result = 0;
            if(num1 != null && num2 != null && symbol != null)
            {
                switch (symbol)
                {
                    case '+':
                        result = num1 + num2;
                        *//*Console.WriteLine($"{num1} + {num2} = {num1 + num2}");*//*
                        break;
                    case '-':
                        result = num2 - num1;
                        *//*Console.WriteLine($"{num1} - {num2} = {num1 - num2}");*//*
                        break;
                    case '*':
                        result = num1 * num2;
                        *//*Console.WriteLine($"{num1} * {num2} = {num1} * {num2}");*//*
                        break;
                    case '/':
                        result = num1 / num2;
                        *//*Console.WriteLine($"{num1} / {num2} = {num1 / num2}");*//*
                        break;
                    default:
                        Console.WriteLine("Error input");
                        break;
                }
                *//*result = Math.Round(result, 2);*//*
                Console.WriteLine($"{num1} {symbol} {num2} = {Math.Round(result,2)}");
                
            }*/

            //Task 2
            /*Console.Write("num:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            if (userNum != null)
            {
                if (userNum >= 2)
                {
                    if (userNum % 2 == 0)
                    {
                        Console.WriteLine($"{userNum} is Even");
                    }
                    else
                    {
                        Console.WriteLine($"{userNum} is Odd!");
                    }
                }
                else
                {
                    Console.WriteLine("Your number is less than 2");
                }
            }
            else
            {
                Console.WriteLine("Error Input!");
            }*/

            //Task 3
            /*Console.Write("Градус в Цельсиях:");
            double tempCelcius = Convert.ToDouble(Console.ReadLine());
            double tempfarengeit = (tempCelcius * 9) / 5 + 32;
            Console.WriteLine($"{tempCelcius} Градусов цельсия равна {tempfarengeit}  Градусов в Фаренгейтах");*/

            int comp = random.Next(1,100);
            Console.WriteLine($"Задуманное число - {comp}");

            
            
            bool success = false;
            
            while (!success)
            {
                Console.Write("Угадай число:");
                int num = Convert.ToInt32(Console.ReadLine());
                if (comp > num)
                {
                    Console.WriteLine("Больше!");
                    
                }
                else if (comp < num)
                {
                    Console.WriteLine("Меньше!");
                    
                }
                else
                {
                    Console.WriteLine($"Поздравляю!Вы угадали число!Ваше число - {num}");
                    success = true;
                }
            }
        }
    }
}
