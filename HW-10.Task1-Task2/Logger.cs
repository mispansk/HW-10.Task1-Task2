using System;
using System.Collections.Generic;
using System.Text;

namespace HW_10.Task1_Task2
{/// <summary>
/// класс, по установке цвета шрифта
/// </summary>
    class Logger: ILogger
    {
        /// <summary>
        /// установка цвета для вывода текста ошибки
        /// </summary>
        /// <param name="message"> текст ошибки </param>
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black;  // восстанавливаем обычную
            Console.ForegroundColor = ConsoleColor.White;  // цветовую гамму
        }
        /// <summary>
        /// установка цвета для текста события 
        /// </summary>
        /// <param name="message"> текст события </param>
        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black;  // восстанавливаем обычную 
            Console.ForegroundColor = ConsoleColor.White;  // цветовую гамму
        }
    }
}
