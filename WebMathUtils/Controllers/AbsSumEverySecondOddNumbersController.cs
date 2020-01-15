using System;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Задание 1
    /// </summary>
    public class AbsSumEverySecondOddNumbersController : ApiController
    {
        /// <summary>
        /// Модуль суммы каждого второго нечетного числа из массива чисел
        /// </summary>
        /// <param name="numbers">Массив чисел</param>
        /// <returns>Модуль суммы</returns>
        public int Post([FromBody]int[] numbers)
        {
            int resultSum = 0;
            int oddCount = 0;
            foreach(int number in numbers)
            {
                if(number % 2 == 1) //Число нечетное
                {
                    oddCount++;
                    if (oddCount % 2 == 0) //Каждое втрое
                        resultSum += number;
                }

            }
            return Math.Abs(resultSum);
        }
    }
}
