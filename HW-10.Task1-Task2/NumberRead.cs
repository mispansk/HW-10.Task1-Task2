using System;
using System.Collections.Generic;
using System.Text;

namespace HW_10.Task1_Task2
{
    /// <summary>
    /// класс по работе с пользователем
    /// </summary>
    public class NumberRead
    {
        ILogger Logger { get; }
        public NumberRead(ILogger logger)
        {
            Logger = logger;
        }      
        /// <summary>
        /// метод , который реализует диалог спользователем
        /// </summary>
        /// <param name="massege"> текст сообщения </param>
        /// <returns> возвращае введенное число </returns>
        public double Read(string massege )
        {
            double number = 0;
            bool flag = true;
            while (flag) // воодим число до тех пор, пока оно не станет корректным
            {
                try
                {
                    Logger.Event(massege);
                    number = Convert.ToInt32(Console.ReadLine());
                    flag = false;                  
                }
                catch (FormatException)
                {
                    Logger.Error("Введено некорректное число, попробуйте еще раз:");                  
                }
            }
            return number;           
        }
    }
}
