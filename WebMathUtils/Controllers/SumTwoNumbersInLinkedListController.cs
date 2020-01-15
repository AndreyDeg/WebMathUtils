using System.Collections.Generic;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Задание 2
    /// </summary>
    public class SumTwoNumbersInLinkedListController : ApiController
    {
        /// <summary>
        /// Сложение двух чисел из связанных списков
        /// </summary>
        /// <param name="firstNumber">первый список</param>
        /// <param name="secondNumber">второй список</param>
        /// <returns>сумма двух списков</returns>
        public LinkedList<int> Post([FromBody]LinkedList<int> firstNumber, [FromBody]LinkedList<int> secondNumber)
        {
            LinkedList<int> resultSum = new LinkedList<int>();

            var firstNode = firstNumber.First;
            var secondNode = secondNumber.First;
            int addition = 0;
            while (firstNode != null || secondNode != null || addition > 0)
            {
                if (firstNode != null)
                    addition += firstNode.Value;
                if (secondNode != null)
                    addition += secondNode.Value;

                resultSum.AddLast(addition % 10);
                addition /= 10; //Для переноса разрядов при сложении

                if (firstNode != null)
                    firstNode = firstNode.Next;
                if (secondNode != null)
                    secondNode = secondNode.Next;
            }

            return resultSum;
        }
    }
}
