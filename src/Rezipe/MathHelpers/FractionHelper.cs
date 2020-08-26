using System;
using System.Globalization;

namespace Rezipe.MathHelpers
{
    public class FractionHelper
    {
        /// <summary>
        /// Formats a real number as a fraction string with a whole part and a fraction part.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="epsilon"></param>
        /// <returns></returns>
        public static string FormatFraction(decimal num, double epsilon = 0.0001)
        {
            var fraction = RealToFraction((double)num, epsilon);

            var n = fraction.N;
            var d = fraction.D;

            var wholePart = 0;

            if (n >= d)
            {
                wholePart = n / d;
                n -= d * wholePart;
            }

            var ret = new System.Text.StringBuilder();
            if (wholePart > 0)
            {
                ret.AppendFormat(wholePart.ToString(CultureInfo.CurrentCulture));
            }

            if (n != 0)
            {
                if (wholePart > 0)
                {
                    ret.Append(" ");
                }

                // If there's still a fraction part left, append it
                ret.AppendFormat(CultureInfo.InvariantCulture, "{0}/{1}", n, d);
            }

            return ret.ToString();
        }

        /// <summary>
        /// Convert a real number to a fraction.
        /// Based on code from https://stackoverflow.com/questions/5124743/algorithm-for-simplifying-decimal-to-fractions
        /// by Kay Zed under CC BY-SA 3.0.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="accuracy"></param>
        /// <returns></returns>
        public static Fraction RealToFraction(double value, double accuracy)
        {
            if (accuracy <= 0.0 || accuracy >= 1.0)
            {
                throw new ArgumentOutOfRangeException(nameof(accuracy), "Must be > 0 and < 1.");
            }

            var sign = Math.Sign(value);

            if (sign == -1)
            {
                value = Math.Abs(value);
            }

            // Accuracy is the maximum relative error; convert to absolute maxError
            var maxError = sign == 0 ? accuracy : value * accuracy;

            var n = (int)Math.Floor(value);
            value -= n;

            if (value < maxError)
            {
                return new Fraction(sign * n, 1);
            }

            if (1 - maxError < value)
            {
                return new Fraction(sign * (n + 1), 1);
            }

            // The lower fraction is 0/1
            var lower_n = 0;
            var lower_d = 1;

            // The upper fraction is 1/1
            var upper_n = 1;
            var upper_d = 1;

            while (true)
            {
                // The middle fraction is (lower_n + upper_n) / (lower_d + upper_d)
                var middle_n = lower_n + upper_n;
                var middle_d = lower_d + upper_d;

                if (middle_d * (value + maxError) < middle_n)
                {
                    // real + error < middle : middle is our new upper
                    Seek(ref upper_n, ref upper_d, lower_n, lower_d, (un, ud) => (lower_d + ud) * (value + maxError) < (lower_n + un));
                }
                else if (middle_n < (value - maxError) * middle_d)
                {
                    // middle < real - error : middle is our new lower
                    Seek(ref lower_n, ref lower_d, upper_n, upper_d, (ln, ld) => (ln + upper_n) < (value - maxError) * (ld + upper_d));
                }
                else
                {
                    // Middle is our best fraction
                    return new Fraction((n * middle_d + middle_n) * sign, middle_d);
                }
            }
        }

        /// <summary>
        /// Binary seek for the value where f() becomes false.
        /// </summary>
        private static void Seek(ref int a, ref int b, int ainc, int binc, Func<int, int, bool> f)
        {
            a += ainc;
            b += binc;

            if (f(a, b))
            {
                var weight = 1;

                do
                {
                    weight *= 2;
                    a += ainc * weight;
                    b += binc * weight;
                }
                while (f(a, b));

                do
                {
                    weight /= 2;

                    var adec = ainc * weight;
                    var bdec = binc * weight;

                    if (!f(a - adec, b - bdec))
                    {
                        a -= adec;
                        b -= bdec;
                    }
                }
                while (weight > 1);
            }
        }
    }
}
