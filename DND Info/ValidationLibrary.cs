using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND_Info
{
    internal class ValidationLibrary
    {
        public static bool IsANumber(string num)
        {
            bool parsed = Double.TryParse(num, out Double number);
            return parsed;
        }

        public static bool IsMaxLength(string len, int length)
        {
            if (len.Length <= length)
            {
                return true;
            }
            return false;
        }

        public static bool IsNumberedList(List<string> numbers)
        {
            foreach (string number in numbers) {
                bool passed = Double.TryParse(number, out Double number2);
                if (!passed) { return false; }
            }
            return true;
        }
    }
}
