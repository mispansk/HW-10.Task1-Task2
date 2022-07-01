using System;
using System.Collections.Generic;
using System.Text;

namespace HW_10.Task1_Task2
{/// <summary>
/// класс, для подсчета суммы элементов
/// </summary>  
    class Calculator : ICalculator
    {
        ILogger Logger { get; }
        public Calculator(ILogger logger)
        {
            Logger = logger;
        }
        /// <summary>
        /// метод, который складываает два числа
        /// </summary>
        /// <param name="a"> первое число </param>
        /// <param name="b"> второе число </param>
        public void Sum(double a, double b)
        {
            Logger.Event("Сумма чисел равна:");
            Console.WriteLine(a + b);
        }
    }
}
