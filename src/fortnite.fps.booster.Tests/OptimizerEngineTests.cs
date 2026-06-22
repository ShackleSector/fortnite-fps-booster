namespace fortnite.fps.booster.Tests;

public class OptimizerEngineTests
{
    [Fact]
    public void Run_ReturnsCompletedReport()
    {
        var engine = new fortnite.fps.booster.Core.OptimizerEngine();
        var report = engine.Run(fortnite.fps.booster.Core.OptimizationProfile.Balanced);
        Assert.NotEmpty(report.Steps);
    }
}
