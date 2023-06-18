namespace StringNumbersMath
{
    public class Division
    {
        public static string Divide(string divisor, string dividend)
        {
            Misc.RemoveLeadingZeros(ref divisor);
            Misc.RemoveLeadingZeros(ref dividend);

            if (dividend == "0") return "Can't divide by 0!";
            if (divisor == "0") return "0";

            string quotient = string.Empty;

            bool isFractional = false;
            int precision = 0;

            Queue<string> digits = new();

            for (int i = 0; i < divisor.Length; i++)
            {
                digits.Enqueue(divisor[i].ToString());
            }

            string currentDividend = digits.Dequeue();
            bool isNextStep = false;

            while (digits.Count > 0 && Misc.IsSmaller(dividend, currentDividend))
            {
                currentDividend += digits.Dequeue();
            }

            while (precision < 6)
            {
                while (currentDividend == "0" && digits.Count > 0)
                {
                    currentDividend = digits.Dequeue();
                    if (currentDividend == "0") quotient += "0";
                }

                while (Misc.IsSmaller(dividend, currentDividend) && digits.Count > 0)
                {
                    currentDividend += digits.Dequeue();
                    if (Misc.IsSmaller(dividend, currentDividend))
                    {
                        quotient += "0";
                    }
                }

                if (digits.Count == 0)
                {
                    while (Misc.IsSmaller(dividend, currentDividend))
                    {
                        if (isFractional == false)
                        {
                            if (quotient.Length == 0) quotient = "0.";
                            else quotient += ".";

                            isFractional = true;
                        }
                        else
                        {
                            if (isNextStep == false)
                            {
                                quotient += "0";
                                precision++;
                            }
                            isNextStep = false;

                            if (precision == 6) break;
                        }

                        currentDividend += "0";
                    }
                }

                int count = 0;
                string product;

                do
                {
                    count++;
                    product = Multiplication.Multiply(dividend, count.ToString());
                } while (currentDividend != product && Misc.IsSmaller(currentDividend, product));

                if (currentDividend != product)
                {
                    product = Misc.NonNegativeSubtract(product, dividend);
                    count--;
                }

                currentDividend = Misc.NonNegativeSubtract(currentDividend, product);
                isNextStep = true;
                quotient += count.ToString();
                if (isFractional) precision++;

                if (currentDividend == "0" && digits.Count == 0) break;
            }

            if (isFractional && precision >= 6 &&
                Misc.CharToInt(quotient[^1]) >= 5 &&
                Misc.CharToInt(quotient[^2]) != 9)
            {
                int n = Misc.CharToInt(quotient[^2]) + 1;
                quotient = quotient[..^2] + Misc.IntRemainderToChar(n);
            }
            else
            {
                quotient = quotient[..^1];
            }

            Misc.RemoveLeadingZeros(ref quotient, isFractional);
            Misc.RemoveTrailingZeros(ref quotient);
            return quotient;
        }
    }
}
