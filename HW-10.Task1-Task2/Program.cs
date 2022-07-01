using System;

namespace HW_10.Task1_Task2
{
    public interface ILogger
    {
        void Error(string message);
        void Event(string message);
    }
    public interface ICalculator
    {     
        void Sum(double a, double b);   
    }
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            
            Logger = new Logger();
            Calculator calculator = new Calculator(Logger);
            NumberRead number = new NumberRead(Logger);
            double a = number.Read("Введите первое число:");
            double b = number.Read("Введите второе число:");
            calculator.Sum(a, b);
            Console.ReadKey();
        }
    }
}
