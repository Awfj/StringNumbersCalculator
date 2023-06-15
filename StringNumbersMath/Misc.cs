using System.Text.RegularExpressions;

namespace StringNumbersMath
{
    internal class Misc
    {
        internal static void Reverse(ref string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            s = new(charArray);
        }

        internal static int CharToInt(char ch)
        {
            return ch - '0';
        }

        internal static char IntRemainderToChar(int n)
        {
            return (char)(n % 10 + '0');
        }

        internal static bool IsSmaller(string a, string b)
        {
            if (a.Length > b.Length)
            {
                return true;
            }
            else if (a.Length == b.Length)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if (CharToInt(a[i]) > CharToInt(b[i]))
                    {
                        return true;
                    }
                    else if (CharToInt(a[i]) < CharToInt(b[i]))
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        internal static void ReassignStringsByValueOrLength(ref string a, ref string b)
        {
            if (IsSmaller(a, b)) (a, b) = (b, a);
        }

        internal static string NonNegativeSubtract(string subtrahend, string minuend)
        {
            ReassignStringsByValueOrLength(ref subtrahend, ref minuend);
            Reverse(ref subtrahend);
            Reverse(ref minuend);

            string difference = string.Empty;
            int carry = 0;
            int currentDifference;

            for (int i = 0; i < subtrahend.Length; i++)
            {
                int currentSubtrahend = CharToInt(subtrahend[i]);
                int currentMinuend = CharToInt(minuend[i]);

                if (currentMinuend < currentSubtrahend + carry)
                {
                    currentMinuend += 10;
                    currentDifference = currentMinuend - currentSubtrahend - carry;
                    carry = 1;
                }
                else
                {
                    currentDifference = currentMinuend - currentSubtrahend - carry;
                    carry = 0;
                }

                difference += currentDifference;
            }

            for (int i = subtrahend.Length; i < minuend.Length; i++)
            {
                int bN = CharToInt(minuend[i]);
                if (bN < carry)
                {
                    bN += 10;
                    currentDifference = bN - carry;
                    carry = 1;
                }
                else
                {
                    currentDifference = bN - carry;
                    carry = 0;
                }

                difference += currentDifference;
            }

            Reverse(ref difference);
            RemoveLeadingZeros(ref difference);

            return difference;
        }

        internal static void RemoveLeadingZeros(ref string s, bool isFractional = false)
        {
            s = Regex.Replace(s, "^0+", "");
            if (s.Length == 0) s = "0";
            if (isFractional && s[0] == '.') s = "0" + s;
        }

        internal static void RemoveTrailingZeros(ref string s)
        {
            s = Regex.Replace(s, "0+$", "");
            if (s[^1] == '.') s = s[..^1];
        }
    }
}
