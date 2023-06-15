namespace StringNumbersMath
{
    public class Summation
    {
        public static string Sum(string addend, string augend)
        {
            Misc.ReassignStringsByValueOrLength(ref addend, ref augend);
            Misc.Reverse(ref addend);
            Misc.Reverse(ref augend);

            string sum = string.Empty;
            int carry = 0;

            for (int i = 0; i < addend.Length; i++)
            {
                int tempSum = Misc.CharToInt(addend[i]) + Misc.CharToInt(augend[i]) + carry;
                sum += Misc.IntRemainderToChar(tempSum);
                carry = tempSum / 10;
            }

            for (int i = addend.Length; i < augend.Length; i++)
            {
                int tempSum = Misc.CharToInt(augend[i]) + carry;
                sum += Misc.IntRemainderToChar(tempSum);
                carry = tempSum / 10;
            }

            if (carry != 0) sum += "1";

            Misc.Reverse(ref sum);
            return sum;
        }
    }
}