namespace TDigestNet
{
    /// <inheritdoc />
    public class TDigestUtils
    {
        /// <summary>
        /// Round value based on digits on precision. Basically it gets the most significant decimal digit and round at that decimal
        /// </summary>
        /// <param name="value">The value to be rounded</param>
        /// <param name="uncertainty">The uncertainty for the rounding</param>
        /// <returns></returns>
        public static double RoundWithPrecision(double value, double uncertainty)
        {
            string sci = uncertainty.ToString("0.0e+0", System.Globalization.CultureInfo.InvariantCulture);

            int exponent = int.Parse(sci.Split('e')[1], System.Globalization.CultureInfo.InvariantCulture);

            int decimals = Math.Max(0, -exponent);

            return Math.Round(value, decimals, MidpointRounding.AwayFromZero);
        }
    }
}
