using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using TelerikUI;
using System.Collections.Generic;

namespace TelerikUISample
{
	public partial class TelerikUISampleViewController : UIViewController
	{
		TKChart chart;

		public TelerikUISampleViewController () : base ("TelerikUISampleViewController", null)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			View.BackgroundColor = UIColor.White;

			// Perform any additional setup after loading the view, typically from a nib.
			var bounds = View.Bounds;
			bounds.Inflate (-20f, -20f);
			chart = new TKChart (bounds);
			chart.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;

			View.AddSubview (chart);

			InitialiseChart ();
		}

		void InitialiseChart ()
		{
			var label = new UILabel (new RectangleF ());
			chart.RemoveAllData ();
			var datapoints = new List<TKChartDataPoint> ();
			var rand = new Random ();

			for (int i = 0; i < 8; i++) {
				datapoints.Add (new TKChartDataPoint (NSObject.FromObject (i + 1), NSObject.FromObject (rand.Next (0, 100))));
			}

			var series = new TKChartColumnSeries (datapoints.ToArray ());
			series.Style.PaletteMode = TKChartSeriesStylePaletteMode.UseItemIndex;
			series.SelectionMode = TKChartSeriesSelectionMode.DataPoint;
			chart.AddSeries (series);

			chart.ReloadData ();
		}
	}
}

