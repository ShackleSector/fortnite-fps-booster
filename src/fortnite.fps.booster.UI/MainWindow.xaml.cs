namespace fortnite.fps.booster.UI;

public partial class MainWindow
{
    private readonly fortnite.fps.booster.Core.OptimizerEngine _engine = new();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnOptimizeClick(object sender, EventArgs e)
    {
        var report = _engine.Run(fortnite.fps.booster.Core.OptimizationProfile.Performance);
        StatusText.Text = report.Steps[^1];
    }
}
