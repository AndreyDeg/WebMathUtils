using System.Web.Http;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Задание 3
    /// </summary>
    public class CheckPalindromeController : ApiController
    {
        /// <summary>
        /// Проверка входящий строки является ли она палиндромом
        /// </summary>
        /// <param name="text">Проверяемая строка</param>
        /// <returns>Является ли она палиндромом</returns>
        public bool Get(string text)
        {
            text = text.Replace(" ", "").ToLower();
            for (int left = 0, right = text.Length - 1; left < right; left++, right--)
                if (text[left] != text[right])
                    return false;

            return true;
        }
    }
}
