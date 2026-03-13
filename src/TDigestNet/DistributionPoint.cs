namespace TDigestNet;

/// <summary>
/// An objects that contain a value (x-axis) and a count (y-axis)
/// which can be used to plot a distribution of the data set
/// </summary>
/// <param name="Mean">The value (x-axis)</param>
/// <param name="Count">The count (y-axis)</param>
/// <param name="Perc">The percentage based on Count</param>
public record struct DistributionPoint(double Mean, double Count, double Perc);