/// <summary>
/// The basic struct that has data for a centroid
/// </summary>
public struct DistributionPoint
{
    /// <summary>
    /// The mean of the centroid
    /// </summary>
    public double Mean { get; }

    /// <summary>
    /// The number of samples inside 
    /// </summary>
    public double Count { get; }

    /// <summary>
    /// The percentage over the entire group of samples into a TDigest object
    /// </summary>
    public double Perc { get; }

    /// <summary>
    /// Construct an Centroid with mean, count and percentage
    /// </summary>
    public DistributionPoint(double mean, double count, double perc)
    {
        Mean = mean;
        Count = count;
        Perc = perc;
    }

    /// <summary>
    /// A simple representation of the centroid
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"(Mean:{Mean} Count:{Count} Perc:{Perc})";
    }
}

