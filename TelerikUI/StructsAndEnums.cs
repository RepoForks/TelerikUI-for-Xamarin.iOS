using System;

namespace TelerikUI
{
	[Flags]
	public enum TKRectSide
	{
		Top = 1 << 0,
		Bottom = 1 << 1,
		Left = 1 << 2,
		Right = 1 << 3,
		All = Top | Bottom | Left | Right
	}

	public enum TKChartSelectionMode
	{
		Single,
		Multiple
	}

	public enum TKChartLegendPosition
	{
		Left,
		Right,
		Top,
		Bottom,
		Floating
	}

	public enum TKChartLegendOffsetOrigin
	{
		TopLeft,
		TopRight,
		BottomLeft,
		BottomRight
	}

	public enum TKChartTitlePosition
	{
		Left,
		Right,
		Top,
		Bottom
	}

	public enum TKBalloonShapeArrowPosition
	{
		None = 0,
		Left = 1,
		Right = 2,
		Top = 3,
		Bottom = 4,
		LeftTop = 5,
		LeftBottom = 6,
		RightTop = 7,
		RightBottom = 8,
		TopLeft = 9,
		TopRight = 10,
		BottomLeft = 11,
		BottomRight = 12
	}

	public enum TKChartSeriesSelectionMode
	{
		None,
		Series,
		DataPoint
	}

	public enum TKShapeType
	{
		None,
		Square,
		Circle,
		TriangleUp,
		TriangleDown,
		Rhombus,
		Pentagon,
		Hexagon,
		Star,
		Heart
	}

	public enum TKLayoutStretchMode
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2
	}

	public enum TKLayoutAlignmentMode
	{
		Left = 1,
		Top = 2,
		Right = 4,
		Bottom = 8,
		HorizontalCenter = 16,
		VerticalCenter = 32
	}

	public enum TKLayoutSizingMode
	{
		Fixed,
		Fit
	}

	public enum TKStackLayoutOrientation
	{
		Horizontal,
		Vertical
	}

	public enum TKStackLayoutItemOrder
	{
		Normal,
		Reverse
	}

	public enum TKGradientRadiusType
	{
		Pixels,
		RectMin,
		RectMax
	}

	public enum TKImageFillResizingMode
	{
		Tile,
		Stretch,
		None
	}

	public enum TKChartGridZPosition
	{
		BelowSeries,
		AboveSeries
	}

	public enum TKGridDrawOrder
	{
		ModeHorizontalFirst,
		ModeVerticalFirst
	}

	public enum TKChartSeriesStylePaletteMode
	{
		UseSeriesIndex,
		UseItemIndex
	}

	public enum TKChartSeriesStyleShapeMode
	{
		ShowOnMiddlePointsOnly,
		AlwaysShow
	}

	public enum TKChartAxisClippingMode
	{
		Visible,
		Hidden
	}

	public enum TKChartAxisLabelFitMode
	{
		None,
		Multiline,
		Rotate
	}

	public enum TKChartAxisLabelAlignment
	{
		Left = 1 << 0,
		Right = 1 << 1,
		Top = 1 << 2,
		Bottom = 1 << 3,
		HorizontalCenter = 1 << 4,
		VerticalCenter = 1 << 5
	}

	public enum TKChartAxisPosition
	{
		Left,
		Right,
		Top,
		Bottom
	}

	public enum TKChartAxisPlotMode
	{
		OnTicks,
		BetweenTicks
	}

	public enum TKChartNumericAxisLabelDisplayMode
	{
		Value,
		Percentage
	}

	public enum TKChartDateTimeAxisIntervalUnit
	{
		Seconds,
		Minutes,
		Hours,
		Days,
		Weeks,
		Months,
		Years,
		Custom
	}

	public enum TKChartStackMode
	{
		Stack,
		Stack100
	}

	public enum TKChartPieSeriesLabelDisplayMode
	{
		Value,
		Percentage,
		Name,
		None
	}

	public enum TKChartAnnotationZPosition
	{
		BelowSeries,
		AboveSeries
	}

	public enum TKChartBalloonVerticalAlignment
	{
		Center = 0,
		Top = 1,
		Bottom = 2
	}

	public enum TKChartBalloonHorizontalAlignment
	{
		Center = 0,
		Left = 1,
		Right = 2
	}

	public enum TKChartBalloonAnnotationTextOrientation
	{
		Vertical,
		Horizontal
	}

	public enum TKChartCrossLineAnnotationOrientation
	{
		Horizontal = 1 << 0,
		Vertical = 1 << 1
	}

	public enum TKChartTrackballSnapMode
	{
		ClosestPoint,
		AllClosestPoints
	}

	public enum TKChartTrackballOrientation
	{
		Horizontal,
		Vertical
	}

	public enum TKChartTrackballPinPosition
	{
		None,
		Left,
		Right,
		Top,
		Bottom
	}

	public enum TKChartAxisTitleAlignment
	{
		Center,
		LeftOrTop,
		RightOrBottom
	}
}

