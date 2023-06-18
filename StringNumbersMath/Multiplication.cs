namespace StringNumbersMath
{
    public class Multiplication
    {
        public static string Multiply(string multiplier, string multiplicand)
        {
            Misc.ReassignStringsByValueOrLength(ref multiplier, ref multiplicand);
            Misc.Reverse(ref multiplier);
            Misc.Reverse(ref multiplicand);

            List<string> products = new();

            for (int i = 0; i < multiplier.Length; i++)
            {
                string tempProduct = string.Empty;
                int carry = 0;

                for (int j = 0; j < multiplicand.Length; j++)
                {
                    int currentProduct = Misc.CharToInt(multiplier[i]) *
                        Misc.CharToInt(multiplicand[j]) + carry;
                    tempProduct += Misc.IntRemainderToChar(currentProduct);
                    carry = currentProduct / 10;
                }

                tempProduct += carry;
                Misc.Reverse(ref tempProduct);
                Misc.RemoveLeadingZeros(ref tempProduct);

                tempProduct += new string('0', products.Count);
                products.Add(tempProduct);
            }

            string product = products[0];

            if (products.Count > 1)
            {
                for (int i = 1; i < products.Count; i++)
                {
                    product = Summation.Sum(products[i], product);
                }
            }

            return product;
        }
    }
}
