namespace TDigestNet
{
    /// <inheritdoc />
    public class TDigestUtils
    {
        /// <summary>
        /// Round value based on digits on precision. Basically it gets the most significant decimal digit and round at that decimal
        /// </summary>
        /// <param name="value">The value to be rounded</param>
        /// <param name="precision">The uncertainty for the rounding</param>
        /// <returns></returns>
        public static double RoundWithPrecision(double value, double precision)
        {
            // Determine the exponent (base-10) of the precision without string conversions.
            // Use the absolute precision to compute the order of magnitude.
            if (precision == 0.0)
            {
                // For zero precision fallback to returning the original value to avoid divide-by-zero.
                return value;
            }

            double absPrecision = Math.Abs(precision);
            int exponent = (int)Math.Floor(Math.Log10(absPrecision));

            int decimals = Math.Max(0, -exponent);

            if (decimals > 0)
            {
                return Math.Round(value, decimals, MidpointRounding.AwayFromZero);
            }

            return Math.Round(value / precision, MidpointRounding.AwayFromZero) * precision;
        }

    }
}
