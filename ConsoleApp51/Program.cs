namespace ConsoleApp51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            int numberStartExample = 0;
            int stepInExample = 3;
            int stepInExample2 = 5;
            int randomNumberMinimum = 0;
            int randomNumberMaximum = 101;
            float result;
            number = random.Next(randomNumberMinimum, randomNumberMaximum);

            Console.WriteLine("Ваше число:" + number);

            result = (number - (number % stepInExample)) + (number - (number % stepInExample2));

            Console.WriteLine("Общая сумма, кратных - " + stepInExample + " и " + stepInExample2 + ", равна - " + result);
        }
    }
}