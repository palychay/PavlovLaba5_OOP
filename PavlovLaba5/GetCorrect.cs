using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PavlovLaba5
{
    static internal class GetCorrect
    {
        private static bool TryParse<T>(string input, out T result) where T : IComparable<T>
        {
            try
            {
                result = (T)Convert.ChangeType(input, typeof(T));
                return true;
            }
            catch
            {
                result = default;
                return false;
            }
        }
        public static bool ValidityEnter<T>(ref T value, T low, T high) where T : IComparable<T>
        {
            string input = Console.ReadLine();

            bool isValid = TryParse(input, out T parsedValue);

            if (isValid && parsedValue.CompareTo(low) >= 0 && parsedValue.CompareTo(high) <= 0)
            {
                value = parsedValue;
                return true;
            }

            return false;
        }
        public static T ValidityEnterInteractive<T>(T low, T high) where T : IComparable<T>
        {
            T x = default;
            while (!ValidityEnter(ref x, low, high))
            {
                Console.WriteLine($"Должно быть от {low} до {high}");
            }
            return x;
        }
    }
}
