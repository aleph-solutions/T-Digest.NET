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
            string sci = precision.ToString("0.0e+0", System.Globalization.CultureInfo.InvariantCulture);

            int exponent = int.Parse(sci.Split('e')[1], System.Globalization.CultureInfo.InvariantCulture);

            int decimals = Math.Max(0, -exponent);
            double valueRounded;

            if (decimals > 0)
                valueRounded = Math.Round(value, decimals, MidpointRounding.AwayFromZero);
            else
                valueRounded = Math.Round(value / precision, MidpointRounding.AwayFromZero) * precision;

            return valueRounded;
        }

    }
}
