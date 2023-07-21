using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Annotations;
using OxyPlot.Series;

namespace SmallDAS
{
    public partial class MagCalibrationView : UserControl
    {
        private ScatterSeries scatterSeriesXY;
        private ScatterSeries scatterSeriesXZ;
        private ScatterSeries scatterSeriesYZ;

        public MagCalibrationView()
        {
            InitializeComponent();

            var plotModel = new PlotModel
            {
                Title = "Magnetometer",
                TextColor = OxyColor.FromRgb(150, 150, 150),
                PlotAreaBorderColor = OxyColor.FromRgb(150, 150, 150),
                Background = OxyColor.FromRgb(50, 50, 50)

            };


            plotModel.Axes.Add(new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                MajorGridlineColor = OxyColors.AntiqueWhite,
                MinorGridlineColor = OxyColors.AntiqueWhite,
                MinorTicklineColor = OxyColors.AntiqueWhite,
                TicklineColor = OxyColors.AntiqueWhite,
                ExtraGridlines = new[] { 0.0 },
                ExtraGridlineColor = OxyColors.AntiqueWhite
            });

            plotModel.Axes.Add(new LinearAxis()
            {
                Position = AxisPosition.Left,
                MajorGridlineColor = OxyColors.AntiqueWhite,
                MinorGridlineColor = OxyColors.AntiqueWhite,
                MinorTicklineColor = OxyColors.AntiqueWhite,
                TicklineColor = OxyColors.AntiqueWhite,
                ExtraGridlines = new[] { 0.0 },
                ExtraGridlineColor = OxyColors.AntiqueWhite
            });

            plotModel.Annotations.Add(new EllipseAnnotation { X = 0, Y = 0, Width = 100, Height = 100, Fill = OxyColors.Transparent, Stroke = OxyColors.Red, StrokeThickness = 1 });
            plotModel.Annotations.Add(new EllipseAnnotation { X = 0, Y = 0, Width = 100, Height = 100, Fill = OxyColors.Transparent, Stroke = OxyColors.Green, StrokeThickness = 1 });
            plotModel.Annotations.Add(new EllipseAnnotation { X = 0, Y = 0, Width = 100, Height = 100, Fill = OxyColors.Transparent, Stroke = OxyColors.Blue, StrokeThickness = 1 });

            scatterSeriesXY = new ScatterSeries();
            scatterSeriesXZ = new ScatterSeries();
            scatterSeriesYZ = new ScatterSeries();
            plotModel.Series.Add(scatterSeriesXY);
            plotModel.Series.Add(scatterSeriesXZ);
            plotModel.Series.Add(scatterSeriesYZ);

            plotView1.Model = plotModel;
        }
    }
}
