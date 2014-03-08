using System.Drawing;
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreAnimation;
using System.Collections;
using MonoTouch.ObjCRuntime;

namespace TelerikUI
{
	[BaseType (typeof(NSObject))]
	public partial interface TKRange
	{
		[Static, Export ("rangeWithMinimum:andMaximum:")]
		NSObject RangeWithMinimum (NSObject minimum, NSObject maximum);

		[Export ("minimum", ArgumentSemantic.Retain)]
		NSObject Minimum { get; set; }

		[Export ("maximum", ArgumentSemantic.Retain)]
		NSObject Maximum { get; set; }

		[Export ("initWithMinimum:andMaximum:")]
		IntPtr Constructor (NSObject minimum, NSObject maximum);

		[Export ("setMinimum:andMaximum:")]
		void SetMinimum (NSObject minimum, NSObject maximum);

		[Export ("setMinimum:andMaximum:calcWithCurrent:")]
		void SetMinimum (NSObject minimum, NSObject maximum, bool includeCurrentRange);
	}

	[BaseType (typeof(UIView))]
	public partial interface TKView
	{
		[Export ("fill", ArgumentSemantic.Retain)]
		TKFill Fill { get; set; }

		[Export ("stroke", ArgumentSemantic.Retain)]
		TKStroke Stroke { get; set; }

		[Export ("layout", ArgumentSemantic.Retain)]
		TKLayout Layout { get; set; }
	}

	[BaseType (typeof(NSObject))]
	public partial interface TKMutableArray
	{
		[Export ("count")]
		uint Count { get; }

		[Export ("firstObject")]
		NSObject FirstObject { get; }

		[Export ("lastObject")]
		NSObject LastObject { get; }

		[Export ("array")]
		NSObject [] Array { get; }

		[Export ("initWithArray:")]
		IntPtr Constructor (NSObject[] array);

		[Export ("addObject:")]
		void AddObject (NSObject obj);

		[Export ("removeObject:")]
		void RemoveObject (NSObject obj);

		[Export ("removeObjectAtIndex:")]
		void RemoveObjectAtIndex (uint index);

		[Export ("objectAtIndex:")]
		NSObject ObjectAtIndex (uint index);

		[Export ("objectAtIndexedSubscript:")]
		NSObject ObjectAtIndexedSubscript (uint idx);

		[Export ("setObject:atIndexedSubscript:")]
		void SetObject (NSObject obj, uint idx);
	}

	[Model, BaseType (typeof(NSObject))]
	public partial interface TKLayout
	{
		[Export ("measure:")]
		SizeF Measure (SizeF size);

		[Export ("arrange:")]
		void Arrange (RectangleF rect);

		[Export ("desiredSize")]
		SizeF DesiredSize { get; }

		[Export ("alignmentMode")]
		TKLayoutAlignmentMode AlignmentMode { get; set; }

		[Export ("stretchMode")]
		TKLayoutStretchMode StretchMode { get; set; }

		[Export ("itemWasRemoved")]
		void ItemWasRemoved ();

		[Export ("itemWasAddedInLayout:")]
		void ItemWasAddedInLayout (TKLayout layout);
	}

	[BaseType (typeof(TKLayout))]
	public partial interface TKLayoutItem 
	{
		[Export ("initWithView:")]
		IntPtr Constructor (UIView aView);

		[Export ("initWithLayer:")]
		IntPtr Constructor (CALayer aLayer);

		[Export ("initWithLayout:")]
		IntPtr Constructor (TKLayout aLayout);

		[Export ("content")]
		NSObject Content { get; }

		[Export ("itemWasRemoved")]
		void ItemWasRemoved ();

		[Export ("sizingMode")]
		TKLayoutSizingMode SizingMode { get; set; }

		[Export ("stretchMode")]
		TKLayoutStretchMode StretchMode { get; set; }

		[Export ("alignmentMode")]
		TKLayoutAlignmentMode AlignmentMode { get; set; }

		[Export ("margin")]
		UIEdgeInsets Margin { get; set; }
	}

	//TODO: Add Ienumerable 
	[BaseType (typeof(TKLayout))]
	public partial interface TKStackLayout 
	{
		[Export ("orientation")]
		TKStackLayoutOrientation Orientation { get; set; }

		[Export ("itemOrder")]
		TKStackLayoutItemOrder ItemOrder { get; set; }

		[Export ("itemSpacing")]
		float ItemSpacing { get; set; }

		[Export ("alignmentMode")]
		TKLayoutAlignmentMode AlignmentMode { get; set; }

		[Export ("stretchMode")]
		TKLayoutStretchMode StretchMode { get; set; }

		[Export ("addItem:")]
		bool AddItem (TKLayout item);

		[Export ("insertItem:atIndex:")]
		bool InsertItem (TKLayout item, uint index);

		[Export ("removeItem:")]
		bool RemoveItem (TKLayout item);

		[Export ("removeItemAtIndex:")]
		bool RemoveItemAtIndex (uint index);

		[Export ("removeAllItems")]
		void RemoveAllItems ();

		[Export ("itemAtIndex:")]
		TKLayout ItemAtIndex (uint index);

		[Export ("lastItem")]
		TKLayout LastItem { get; }

		[Export ("count")]
		int Count { get; }
	}

	[Model, BaseType (typeof(NSObject))]
	public partial interface TKDrawing
	{
		[Export ("drawInContext:withRect:")]
		void DrawInContext (CGContext context, RectangleF rect);

		[Export ("drawInContext:withPath:")]
		void DrawInContext (CGContext context, CGPath path);

		[Export ("insets", ArgumentSemantic.Assign)]
		UIEdgeInsets Insets { get; set; }
	}

	[BaseType (typeof(TKDrawing))]
	public partial interface TKFill
	{
		[Export ("alpha")]
		float Alpha { get; set; }

		[Export ("corners")]
		UIRectCorner Corners { get; set; }

		[Export ("cornerRadius")]
		float CornerRadius { get; set; }

		[Export ("insets", ArgumentSemantic.Assign)]
		UIEdgeInsets Insets { get; set; }

		[Export ("drawFillInContext:withRect:")]
		void DrawFillInContext (CGContext context, RectangleF rect);

		[Export ("drawFillInContext:withPath:")]
		void DrawFillInContext (CGContext context, CGPath path);
	}

	[BaseType (typeof(TKFill))]
	public partial interface TKSolidFill
	{
		[Static, Export ("solidFillWithColor:")]
		TKSolidFill SolidFillWithColor (UIColor color);

		[Static, Export ("solidFillWithColor:cornerRadius:")]
		TKSolidFill SolidFillWithColor (UIColor color, float cornerRadius);

		[Export ("initWithColor:")]
		IntPtr Constructor (UIColor color);

		[Export ("initWithColor:cornerRadius:")]
		IntPtr Constructor (UIColor color, float cornerRadius);

		[Export ("color", ArgumentSemantic.Retain)]
		UIColor Color { get; set; }
	}

	[BaseType (typeof(TKFill))]
	public partial interface TKGradientFill
	{
		[Export ("initWithColors:")]
		IntPtr Constructor (NSObject[] colors);

		[Export ("initWithColors:cornerRadius:")]
		IntPtr Constructor (NSObject[] colors, float cornerRadius);

		[Export ("initWithColors:locations:")]
		IntPtr Constructor (NSObject[] colors, NSObject[] locations);

		[Export ("initWithColors:locations:cornerRadius:")]
		IntPtr Constructor (NSObject[] colors, NSObject[] locations, float cornerRadius);

		[Export ("colors")]
		NSObject [] Colors { get; set; }

		[Export ("locations", ArgumentSemantic.Retain)]
		NSObject [] Locations { get; set; }
	}

	[BaseType (typeof(TKGradientFill))]
	public partial interface TKLinearGradientFill
	{
		[Static, Export ("reverse:")]
		TKLinearGradientFill Reverse (TKLinearGradientFill fill);

		[Static, Export ("linearGradientFillWithColors:")]
		TKLinearGradientFill LinearGradientFillWithColors (UIColor[] colors);

		[Static, Export ("linearGradientFillWithColors:startPoint:endPoint:")]
		TKLinearGradientFill LinearGradientFillWithColors (UIColor[] colors, PointF startPoint, PointF endPoint);

		[Static, Export ("linearGradientFillWithColors:locations:startPoint:endPoint:")]
		TKLinearGradientFill LinearGradientFillWithColors (UIColor[] colors, NSNumber[] locations, PointF startPoint, PointF endPoint);

		[Export ("initWithColors:startPoint:endPoint:")]
		IntPtr Constructor (NSObject[] colors, PointF startPoint, PointF endPoint);

		[Export ("initWithColors:locations:startPoint:endPoint:")]
		IntPtr Constructor (NSObject[] colors, NSObject[] locations, PointF startPoint, PointF endPoint);

		[Export ("startPoint", ArgumentSemantic.Assign)]
		PointF StartPoint { get; set; }

		[Export ("endPoint", ArgumentSemantic.Assign)]
		PointF EndPoint { get; set; }
	}

	[BaseType (typeof(TKGradientFill))]
	public partial interface TKRadialGradientFill
	{
		[Static, Export ("radialGradientFillWithColors:")]
		TKRadialGradientFill RadialGradientFillWithColors (UIColor[] colors);

		[Static, Export ("reverse:")]
		TKRadialGradientFill Reverse (TKRadialGradientFill fill);

		[Export ("initWithColors:startCenter:startRadius:endCenter:endRadius:")]
		IntPtr Constructor (NSObject[] colors, PointF startCenter, float startRadius, PointF endCenter, float endRadius);

		[Export ("initWithColors:startCenter:startRadius:endCenter:endRadius:radiusType:")]
		IntPtr Constructor (NSObject[] colors, PointF startCenter, float startRadius, PointF endCenter, float endRadius, TKGradientRadiusType radiusType);

		[Export ("gradientRadiusType")]
		TKGradientRadiusType GradientRadiusType { get; set; }

		[Export ("startRadius")]
		float StartRadius { get; set; }

		[Export ("endRadius")]
		float EndRadius { get; set; }

		[Export ("startCenter", ArgumentSemantic.Assign)]
		PointF StartCenter { get; set; }

		[Export ("endCenter", ArgumentSemantic.Assign)]
		PointF EndCenter { get; set; }
	}

	[BaseType (typeof(TKFill))]
	public partial interface TKImageFill
	{
		[Static, Export ("imageFillWithImage:")]
		TKImageFill ImageFillWithImage (UIImage image);

		[Static, Export ("imageFillWithImage:cornerRadius:")]
		TKImageFill ImageFillWithImage (UIImage image, float cornerRadius);

		[Export ("initWithImage:")]
		IntPtr Constructor (UIImage image);

		[Export ("initWithImage:cornerRadius:")]
		IntPtr Constructor (UIImage image, float cornerRadius);

		[Export ("image", ArgumentSemantic.Retain)]
		UIImage Image { get; set; }

		[Export ("resizingMode")]
		TKImageFillResizingMode ResizingMode { get; set; }
	}

	[BaseType (typeof(TKDrawing))]
	public partial interface TKStroke 
	{
		[Static, Export ("strokeWithColor:")]
		TKStroke StrokeWithColor (UIColor color);

		[Static, Export ("strokeWithColor:width:")]
		TKStroke StrokeWithColor (UIColor color, float width);

		[Static, Export ("strokeWithColor:width:cornerRadius:")]
		TKStroke StrokeWithColor (UIColor color, float width, float cornerRadius);

		[Static, Export ("strokeWithFill:")]
		TKStroke StrokeWithFill (TKFill fill);

		[Static, Export ("strokeWithFill:width:")]
		TKStroke StrokeWithFill (TKFill fill, float width);

		[Static, Export ("strokeWithFill:width:cornerRadius:")]
		TKStroke StrokeWithFill (TKFill fill, float width, float cornerRadius);

		[Export ("width")]
		float Width { get; set; }

		[Export ("lineCap")]
		CGLineCap LineCap { get; set; }

		[Export ("lineJoin")]
		CGLineJoin LineJoin { get; set; }

		[Export ("miterLimit")]
		float MiterLimit { get; set; }

		[Export ("phase")]
		float Phase { get; set; }

		[Export ("corners")]
		UIRectCorner Corners { get; set; }

		[Export ("cornerRadius")]
		float CornerRadius { get; set; }

		[Export ("insets", ArgumentSemantic.Assign)]
		UIEdgeInsets Insets { get; set; }

		[Export ("strokeSides")]
		TKRectSide StrokeSides { get; set; }

		[Export ("dashPattern", ArgumentSemantic.Retain)]
		NSNumber [] DashPattern { get; set; }

		[Export ("fill", ArgumentSemantic.Retain)]
		TKFill Fill { get; set; }

		[Export ("color")]
		UIColor Color { get; }

		[Export ("initWithColor:")]
		IntPtr Constructor (UIColor color);

		[Export ("initWithColor:width:")]
		IntPtr Constructor (UIColor color, float width);

		[Export ("initWithFill:")]
		IntPtr Constructor (TKFill fill);

		[Export ("initWithFill:width:")]
		IntPtr Constructor (TKFill fill, float width);
	}

	[BaseType (typeof(NSObject))]
	public partial interface TKShape
	{
		[Export ("initWithSize:")]
		IntPtr Constructor (SizeF size);

		[Export ("size", ArgumentSemantic.Assign)]
		SizeF Size { get; set; }

		[Export ("insets")]UIEdgeInsets Insets { get; }

		[Export ("drawInContext:withCenter:drawings:")]
		void DrawInContext (CGContext context, PointF center, TKDrawing[] drawings);

		[Export ("drawInContext:withCenter:drawings:scale:")]
		void DrawInContext (CGContext context, PointF center, TKDrawing[] drawings, float scale);
	}

	[BaseType (typeof(TKShape))]
	public partial interface TKPredefinedShape
	{
		[Static, Export ("shapeWithType:andSize:")]
		TKPredefinedShape ShapeWithType (TKShapeType type, SizeF size);

		[Export ("initWithType:andSize:")]
		IntPtr Constructor (TKShapeType type, SizeF size);

		[Export ("type")]
		TKShapeType Type { get; }
	}

	[BaseType (typeof(TKShape))]
	public partial interface TKBalloonShape
	{
		[Export ("initWithArrowPosition:size:")]
		IntPtr Constructor (TKBalloonShapeArrowPosition arrowPosition, SizeF size);

		[Export ("arrowPosition")]
		TKBalloonShapeArrowPosition ArrowPosition { get; set; }

		[Export ("arrowSize", ArgumentSemantic.Assign)]
		SizeF ArrowSize { get; set; }

		[Export ("cornerRadius")]
		float CornerRadius { get; set; }

		[Export ("arrowOffset")]
		float ArrowOffset { get; set; }

		[Export ("useStrictArrowPosition")]
		bool UseStrictArrowPosition { get; set; }
	}

	[BaseType (typeof(CALayer))]
	public partial interface TKLayer
	{
		[Export ("shape", ArgumentSemantic.Retain)]
		TKShape Shape { get; set; }

		[Export ("fill", ArgumentSemantic.Retain)]
		TKFill Fill { get; set; }

		[Export ("stroke", ArgumentSemantic.Retain)]
		TKStroke Stroke { get; set; }

		[Export ("sizeThatFits:")]
		SizeF SizeThatFits (SizeF size);

		[Export ("sizeToFit")]
		void SizeToFit ();
	}

	[BaseType (typeof(TKView))]
	public partial interface TKChart
	{
		[Static, Export ("versionString")]
		string VersionString { get; }

		[Export ("legend")]TKChartLegendView Legend { get; }

		[Export ("title")]TKChartTitleView Title { get; }

		[Export ("plotView")]UIView PlotView { get; }

		[Export ("gridStyle")]TKChartGridStyle GridStyle { get; }

		[Export ("insets", ArgumentSemantic.Assign)]
		UIEdgeInsets Insets { get; set; }
		//		[Export ("theme", ArgumentSemantic.Retain)]
		//		TKTheme Theme { get; set; }
		[Export ("selectionMode")]
		TKChartSelectionMode SelectionMode { get; set; }

		[Export ("allowAnimations")]
		bool AllowAnimations { get; set; }

		[Export ("animate")]
		void Animate ();

		[Export ("delegate", ArgumentSemantic.Assign)]
		TKChartDelegate Delegate { get; set; }

		[Export ("dataSource", ArgumentSemantic.Assign)]
		TKChartDataSource DataSource { get; set; }

		[Export ("xAxis", ArgumentSemantic.Retain)]
		TKChartAxis XAxis { get; set; }

		[Export ("yAxis", ArgumentSemantic.Retain)]
		TKChartAxis YAxis { get; set; }

		[Export ("axes")]
		NSObject [] Axes { get; }

		[Export ("addAxis:")]
		void AddAxis (TKChartAxis axis);

		[Export ("removeAxis:")]
		bool RemoveAxis (TKChartAxis axis);

		[Export ("series")]
		TKChartSeries [] Series { get; }

		[Export ("addSeries:")]
		void AddSeries (TKChartSeries series);

		[Export ("dequeueReusableSeriesWithIdentifier:")]
		NSObject DequeueReusableSeriesWithIdentifier (string identifier);

		[Export ("removeSeries:")]
		void RemoveSeries (TKChartSeries series);

		[Export ("trackball", ArgumentSemantic.Retain)]
		TKChartTrackball Trackball { get; }

		[Export ("allowTrackball")]
		bool AllowTrackball { get; set; }

		[Export ("annotations")]
		NSObject [] Annotations { get; }

		[Export ("addAnnotation:")]
		void AddAnnotation (TKChartAnnotation annotation);

		[Export ("removeAnnotation:")]
		void RemoveAnnotation (TKChartAnnotation annotation);

		[Export ("removeAllAnnotations")]
		void RemoveAllAnnotations ();

		[Export ("updateAnnotations")]
		void UpdateAnnotations ();

		[Export ("reloadData")]
		void ReloadData ();

		[Export ("removeAllData")]
		void RemoveAllData ();

		[Export ("beginUpdates")]
		void BeginUpdates ();

		[Export ("endUpdates")]
		void EndUpdates ();

		[Export ("hitTestForPoint:")]
		TKChartSelectionInfo HitTestForPoint (PointF point);

		[Export ("select:")]
		void Select (TKChartSelectionInfo info);

		[Export ("visualPointsForSeries:")]
		NSObject [] VisualPointsForSeries (TKChartSeries series);

		[Export ("visualPointForSeries:dataPointIndex:")]
		TKChartVisualPoint VisualPointForSeries (TKChartSeries series, int dataPointIndex);

		[Export("initWithFrame:")]
		IntPtr Constructor (RectangleF frame);

	}

	[Model, BaseType (typeof(NSObject))]
	public partial interface TKChartDataSource
	{
		[Export ("numberOfSeriesForChart:")]
		uint NumberOfSeriesForChart (TKChart chart);

		[Export ("seriesForChart:atIndex:")]
		TKChartSeries SeriesForChart (TKChart chart, uint index);

		[Export ("chart:numberOfDataPointsForSeriesAtIndex:")]
		uint Chart (TKChart chart, uint seriesIndex);

		[Export ("chart:dataPointAtIndex:forSeriesAtIndex:")]
		TKChartData Chart (TKChart chart, uint dataIndex, uint seriesIndex);

		[Export ("chart:dataPointsForSeriesAtIndex:")]
		NSObject [] DataPointsForIndex (TKChart chart, uint seriesIndex);
	}

	[Model, BaseType (typeof(NSObject))]
	public partial interface TKChartDelegate
	{
		[Export ("chart:paletteItemForSeries:atIndex:")]
		TKChartPaletteItem PaletteItemForSeries (TKChart chart, TKChartSeries series, uint index);

		[Export ("chart:shapeForSeries:atIndex:")]
		TKShape ShapeForSeries (TKChart chart, TKChartSeries series, uint index);

		[Export ("chart:animationForSeries:withState:inRect:")]
		CAAnimation AnimationForSeries (TKChart chart, TKChartSeries series, TKChartSeriesRenderState state, RectangleF rect);

		[Export ("chart:selectedSeries:dataPoint:dataIndex:")]
		void SelectedSeries (TKChart chart, TKChartSeries series, TKChartData dataPoint, int dataIndex);
		[Export ("chartWillZoom:")]
		void  ChartWillZoom (TKChart chart);

		[Export ("chartDidZoom:")]
		void  ChartDidZoom (TKChart chart);

		[Export ("chartWillPan:")]
		void  ChartWillPan (TKChart chart);

		[Export ("chartDidPan:")]
		void  ChartDidPan (TKChart chart);

		[Export ("chart:trackballDidTrackSelection:")]
		void TrackballDidTrackSelection (TKChart chart,TKChartSelectionInfo[] selection);
	}

	[BaseType (typeof(UIViewController))]
	public partial interface TKChartViewController : TKChartDataSource, TKChartDelegate
	{
//		[Export ("chart", ArgumentSemantic.Retain)]
//		new TKChart Chart { get; set; }
	}

	[Model, BaseType (typeof(NSObject))]
	public partial interface TKChartData
	{
		[Export ("dataXValue")]NSObject DataXValue { get; }

		[Export ("dataYValue")]NSObject DataYValue { get; }

		[Export ("dataName")]string DataName { get; }
	}

	[BaseType (typeof(TKChartData))]
	public partial interface TKChartDataPoint
	{
		[Static, Export ("dataPointWithX:Y:")]
		TKChartDataPoint DataPointWithX (NSObject xValue, NSObject yValue);

		[Static, Export ("dataPointWithX:Y:name:")]
		TKChartDataPoint DataPointWithX (NSObject xValue, NSObject yValue, string name);

		[Export ("initWithX:Y:")]
		IntPtr Constructor (NSObject xValue, NSObject yValue);

		[Export ("initWithX:Y:name:")]
		IntPtr Constructor (NSObject xValue, NSObject yValue, string name);

		[Export ("initWithValue:name:")]
		IntPtr Constructor (NSObject value, string name);

		[Export ("dataXValue", ArgumentSemantic.Retain)]
		NSObject DataXValue { get; set; }

		[Export ("dataYValue", ArgumentSemantic.Retain)]
		NSObject DataYValue { get; set; }

		[Export ("dataName", ArgumentSemantic.Retain)]
		string DataName { get; set; }
	}

	[BaseType (typeof(NSObject))]
	public partial interface TKChartSeries
	{
		[Export ("initWithItems:")]
		IntPtr Constructor (NSObject[] items);

		[Export ("initWithItems:reuseIdentifier:")]
		IntPtr Constructor (NSObject[] items, string reuseIdentifier);

		[Export ("initWithItems:forKeys:")]
		IntPtr Constructor (NSObject[] items, NSDictionary keys);

		[Export ("initWithItems:forKeys:reuseIdentifier:")]
		IntPtr Constructor (NSObject[] items, NSDictionary keys, string reuseIdentifier);

		[Export ("initWithItems:xValueKey:yValueKey:")]
		IntPtr Constructor (NSObject[] items, string xValueKey, string yValueKey);

		[Export ("dataPointAtIndex:")]
		TKChartData DataPointAtIndex (uint dataIndex);

		[Export ("dataPoints")]
		NSObject [] DataPoints { get; }

		[Export ("items")]
		NSObject [] Items { get; }

		[Export ("stackInfo", ArgumentSemantic.Retain)]
		TKChartStackInfo StackInfo { get; set; }

		[Export ("reuseIdentifier", ArgumentSemantic.Copy)]
		string ReuseIdentifier { get; }

		[Export ("prepareForReuse")]
		void PrepareForReuse ();

		[Export ("style", ArgumentSemantic.Retain)]
		TKChartSeriesStyle Style { get; set; }

		[Export ("selectionMode")]
		TKChartSeriesSelectionMode SelectionMode { get; set; }

		[Export ("title", ArgumentSemantic.Retain)]
		string Title { get; set; }

		[Export ("xAxis", ArgumentSemantic.Retain)]
		TKChartAxis XAxis { get; set; }

		[Export ("yAxis", ArgumentSemantic.Retain)]
		TKChartAxis YAxis { get; set; }

		[Export ("tag")]
		int Tag { get; set; }

		[Export ("index")]
		uint Index { get; }

		[Export ("hidden")]
		bool Hidden { get; set; }
	}

	[BaseType (typeof(UILabel))]
	public partial interface TKChartTitleView
	{
		[Export ("position")]
		TKChartTitlePosition Position { get; set; }

//		[Export ("style", ArgumentSemantic.Retain)]
//		TKChartTitleStyle Style { get; set; }
	}

	[BaseType (typeof(UIView))]
	public partial interface TKChartLegendItem
	{
		[Export ("icon", ArgumentSemantic.Retain)]
		UIView Icon { get; set; }

		[Export ("label", ArgumentSemantic.Retain)]
		UILabel Label { get; set; }

		[Export ("selectionInfo", ArgumentSemantic.Retain)]
		TKChartSelectionInfo SelectionInfo { get; set; }

		[Export ("style", ArgumentSemantic.Retain)]
		TKChartLegendItemStyle Style { get; set; }
	}

	[Model, BaseType (typeof(NSObject))]
	public partial interface TKChartLegendItemDelegate
	{
		[Export ("legendItemCountForChart:")]
		uint  LegendCount (TKChart chart);

		[Export ("legendItemForChart:atIndex:")]
		TKChartLegendItem AtIndex (TKChart chart, uint index);
	}

	[BaseType (typeof(UIScrollView))]
	public partial interface TKStackLayoutView
	{
		[Export ("stack", ArgumentSemantic.Retain)]
		TKStackLayout Stack { get; set; }
	}

	[BaseType (typeof(TKStackLayoutView))]
	public partial interface TKChartLegendContainer
	{
		[Export ("addItem:")]
		void AddItem (TKChartLegendItem item);

		[Export ("removeAllItems")]
		void RemoveAllItems ();

		[Export ("itemAtIndex:")]
		TKChartLegendItem ItemAtIndex (uint index);

		[Export ("itemCount")]uint ItemCount { get; }
	}



	[BaseType (typeof(NSObject))]
	public partial interface TKStyleNode
	{
		//		[Export ("styleID", ArgumentSemantic.Retain)]
		//		TKStyleID StyleID { get; set; }
		[Export ("beginThemeBlock")]
		void BeginThemeBlock ();

		[Export ("endThemeBlock")]
		void EndThemeBlock ();

		[Export ("isThemeBlock")]bool IsThemeBlock { get; }

		[Export ("canSetValue:")]
		bool CanSetValue (int value);

		[Export ("resetLocalValues")]
		void ResetLocalValues ();
	}

	[BaseType (typeof(TKStyleNode))]
	public partial interface TKChartLegendStyle
	{
		[Export ("position")]
		TKChartLegendPosition Position { get; set; }

		[Export ("offset", ArgumentSemantic.Assign)]
		UIOffset Offset { get; set; }

		[Export ("offsetOrigin")]
		TKChartLegendOffsetOrigin OffsetOrigin { get; set; }

		[Export ("fill", ArgumentSemantic.Retain)]
		TKFill Fill { get; set; }

		[Export ("stroke", ArgumentSemantic.Retain)]
		TKStroke Stroke { get; set; }
	}

	[BaseType (typeof(TKView))]
	public partial interface TKChartLegendView
	{
		[Export ("titleLabel", ArgumentSemantic.Retain)]
		UILabel TitleLabel { get; }

		[Export ("container", ArgumentSemantic.Retain)]
		TKChartLegendContainer Container { get; }

		[Export ("chart", ArgumentSemantic.Assign)]
		TKChart Chart { get; set; }

		[Export ("showTitle")]
		bool ShowTitle { get; set; }

		[Export ("allowSelection")]
		bool AllowSelection { get; set; }

		[Export ("style", ArgumentSemantic.Retain)]
		TKChartLegendStyle Style { get; set; }

		[Export ("initWithChart:")]
		IntPtr Constructor (TKChart chart);

		[Export ("reloadItems")]
		void ReloadItems ();
	}

	[BaseType (typeof(NSObject))]
	public partial interface TKChartPalette
	{
		[Export ("addPaletteItem:")]
		void AddPaletteItem (TKChartPaletteItem item);

		[Export ("addPaletteItems:")]
		void AddPaletteItems (NSObject[] items);

		[Export ("insertPaletteItem:atIndex:")]
		void InsertPaletteItem (TKChartPaletteItem item, uint index);

		[Export ("replacePaletteItem:atIndex:")]
		void ReplacePaletteItem (TKChartPaletteItem item, uint index);

		[Export ("clearPalette")]
		void ClearPalette ();

		[Export ("paletteItemAtIndex:")]
		TKChartPaletteItem PaletteItemAtIndex (uint index);

		[Export ("items")]
		NSObject [] Items { get; }

		[Export ("itemsCount")]
		uint Count { get; }
	}

	[BaseType (typeof(NSObject))]
	public partial interface TKChartPaletteItem
	{
		[Static, Export ("paletteItemWithFill:")]
		TKChartPaletteItem PaletteItemWithFill (TKFill fill);

		[Static, Export ("paletteItemWithStroke:")]
		TKChartPaletteItem PaletteItemWithStroke (TKStroke stroke);

		[Static, Export ("paletteItemWithStroke:andFill:")]
		TKChartPaletteItem PaletteItemWithStroke (TKStroke stroke, TKFill fill);

		[Static, Export ("paletteItemWithDrawables:")]
		TKChartPaletteItem PaletteItemWithDrawables (TKDrawing[] drawables);

		[Export ("initWithFill:")]
		IntPtr Constructor (TKFill fill);

		[Export ("initWithStroke:")]
		IntPtr Constructor (TKStroke stroke);

		[Export ("initWithStroke:andFill:")]
		IntPtr Constructor (TKStroke stroke, TKFill fill);

		[Export ("initWithDrawables:")]
		IntPtr Constructor (NSObject[] drawables);

		[Export ("textColor", ArgumentSemantic.Retain)]
		UIColor TextColor { get; set; }

		[Export ("font", ArgumentSemantic.Retain)]
		UIFont Font { get; set; }

		[Export ("fill", ArgumentSemantic.Retain)]
		TKFill Fill { get; set; }

		[Export ("stroke", ArgumentSemantic.Retain)]
		TKStroke Stroke { get; set; }

		[Export ("drawables", ArgumentSemantic.Retain)] TKDrawing [] Drawables { get; set; }
	}

	[BaseType (typeof(TKStyleNode))]
	public partial interface TKChartLegendItemStyle
	{
		[Export ("labelStyle", ArgumentSemantic.Retain)]
		TKChartLabelStyle LabelStyle { get; set; }

		[Export ("fill", ArgumentSemantic.Retain)]
		TKFill Fill { get; set; }

		[Export ("stroke", ArgumentSemantic.Retain)]
		TKStroke Stroke { get; set; }

		[Export ("iconSize", ArgumentSemantic.Assign)]
		SizeF IconSize { get; set; }
	}

	[BaseType (typeof(TKStyleNode))]
	public partial interface TKChartGridStyle
	{
		[Export ("zPosition")]
		TKChartGridZPosition ZPosition { get; set; }

		[Export ("verticalLineStroke", ArgumentSemantic.Retain)]
		TKStroke VerticalLineStroke { get; set; }

		[Export ("verticalLineAlternateStroke", ArgumentSemantic.Retain)]
		TKStroke VerticalLineAlternateStroke { get; set; }

		[Export ("verticalLinesHidden")]
		bool VerticalLinesHidden { get; set; }

		[Export ("verticalFill", ArgumentSemantic.Retain)]
		TKFill VerticalFill { get; set; }

		[Export ("verticalAlternateFill", ArgumentSemantic.Retain)]
		TKFill VerticalAlternateFill { get; set; }

		[Export ("horizontalLineStroke", ArgumentSemantic.Retain)]
		TKStroke HorizontalLineStroke { get; set; }

		[Export ("horizontalLineAlternateStroke", ArgumentSemantic.Retain)]
		TKStroke HorizontalLineAlternateStroke { get; set; }

		[Export ("horizontalLinesHidden")]
		bool HorizontalLinesHidden { get; set; }

		[Export ("horizontalFill", ArgumentSemantic.Retain)]
		TKFill HorizontalFill { get; set; }

		[Export ("horizontalAlternateFill", ArgumentSemantic.Retain)]
		TKFill HorizontalAlternateFill { get; set; }

		[Export ("backgroundFill", ArgumentSemantic.Retain)]
		TKFill BackgroundFill { get; set; }

		[Export ("drawOrder")]
		TKGridDrawOrder DrawOrder { get; set; }
	}

	[BaseType (typeof(TKStyleNode))]
	public partial interface TKChartLabelStyle
	{
		[Export ("font", ArgumentSemantic.Retain)]
		UIFont Font { get; set; }

		[Export ("textColor", ArgumentSemantic.Retain)]
		UIColor TextColor { get; set; }

		[Export ("shadowColor", ArgumentSemantic.Retain)]
		UIColor ShadowColor { get; set; }

		[Export ("shadowOffset", ArgumentSemantic.Assign)]
		SizeF ShadowOffset { get; set; }

		[Export ("textHidden")]
		bool TextHidden { get; set; }
	}

	[BaseType (typeof(TKStyleNode))]
	public partial interface TKChartSeriesStyle
	{
		[Export ("palette", ArgumentSemantic.Retain)]
		TKChartPalette Palette { get; set; }

		[Export ("paletteMode")]
		TKChartSeriesStylePaletteMode PaletteMode { get; set; }

		[Export ("pointShape", ArgumentSemantic.Retain)]
		TKShape PointShape { get; set; }

		[Export ("shapeMode")]
		TKChartSeriesStyleShapeMode ShapeMode { get; set; }

		[Export ("shapePalette", ArgumentSemantic.Retain)]
		TKChartPalette ShapePalette { get; set; }
	}

	[BaseType (typeof(TKStyleNode))]
	public partial interface TKChartAxisStyle
	{
		[Export ("lineStroke", ArgumentSemantic.Retain)]
		TKStroke LineStroke { get; set; }

		[Export ("lineHidden")]
		bool LineHidden { get; set; }

		[Export ("backgroundFill", ArgumentSemantic.Retain)]
		TKFill BackgroundFill { get; set; }

		[Export ("labelStyle", ArgumentSemantic.Retain)]
		TKChartAxisLabelStyle LabelStyle { get; }

		[Export ("titleStyle", ArgumentSemantic.Retain)]
		TKChartAxisTitleStyle TitleStyle { get; }

		[Export ("majorTickStyle", ArgumentSemantic.Retain)]
		TKChartAxisMajorTickStyle MajorTickStyle { get; }

		[Export ("minorTickStyle", ArgumentSemantic.Retain)]
		TKChartAxisTickStyle MinorTickStyle { get; }
	}

	[BaseType (typeof(TKChartLabelStyle))]
	public partial interface TKChartAxisLabelStyle
	{
		[Export ("textOffset", ArgumentSemantic.Assign)]
		UIOffset TextOffset { get; set; }

		[Export ("textAlignment")]
		TKChartAxisLabelAlignment TextAlignment { get; set; }

		[Export ("fitMode")]
		TKChartAxisLabelFitMode FitMode { get; set; }

		[Export ("minLabelClippingMode")]
		TKChartAxisClippingMode MinLabelClippingMode { get; set; }

		[Export ("maxLabelClippingMode")]
		TKChartAxisClippingMode MaxLabelClippingMode { get; set; }

		[Export ("firstLabelTextOffset", ArgumentSemantic.Assign)]
		UIOffset FirstLabelTextOffset { get; set; }

		[Export ("firstLabelTextAlignment")]
		TKChartAxisLabelAlignment FirstLabelTextAlignment { get; set; }
	}

	[BaseType (typeof(TKStyleNode))]
	public partial interface TKChartAxisTickStyle
	{
		[Export ("ticksStroke", ArgumentSemantic.Retain)]
		TKStroke TicksStroke { get; set; }

		[Export ("ticksFill", ArgumentSemantic.Retain)]
		TKFill TicksFill { get; set; }

		[Export ("ticksOffset")]
		float TicksOffset { get; set; }

		[Export ("ticksLength")]
		float TicksLength { get; set; }

		[Export ("ticksWidth")]
		float TicksWidth { get; set; }

		[Export ("ticksHidden")]
		bool TicksHidden { get; set; }
	}

	[BaseType (typeof(TKChartAxisTickStyle))]
	public partial interface TKChartAxisMajorTickStyle
	{
		[Export ("minTickClippingMode")]
		TKChartAxisClippingMode MinTickClippingMode { get; set; }

		[Export ("maxTickClippingMode")]
		TKChartAxisClippingMode MaxTickClippingMode { get; set; }
	}

	[BaseType (typeof(TKChartLabelStyle))]
	public partial interface TKChartAxisTitleStyle
	{
		[Export ("alignment")]
		TKChartAxisTitleAlignment Alignment { get; set; }
	}

	[BaseType (typeof(NSObject))]
	public partial interface TKChartAxis
	{
		[Export ("initWithRange:")]
		IntPtr Constructor (TKRange range);

		[Export ("initWithMinimum:andMaximum:")]
		IntPtr Constructor (NSObject minimum, NSObject maximum);

		[Export ("initWithMinimum:andMaximum:position:")]
		IntPtr Constructor (NSObject minimum, NSObject maximum, TKChartAxisPosition position);

		[Export ("numericValue:")]
		double NumericValue (NSObject value);

		[Export ("style", ArgumentSemantic.Retain)]
		TKChartAxisStyle Style { get; set; }

		[Export ("position")]
		TKChartAxisPosition Position { get; set; }

		[Export ("isVertical")]bool IsVertical { get; }

		[Export ("plotMode")]
		TKChartAxisPlotMode PlotMode { get; }

		[Export ("title", ArgumentSemantic.Retain)]
		string Title { get; set; }

		[Export ("attributedTitle", ArgumentSemantic.Retain)]
		NSAttributedString AttributedTitle { get; set; }

		[Export ("labelFormat", ArgumentSemantic.Retain)]
		string LabelFormat { get; set; }

		[Export ("labelFormatter", ArgumentSemantic.Retain)]
		NSFormatter LabelFormatter { get; set; }

		[Export ("range", ArgumentSemantic.Retain)]
		TKRange Range { get; set; }

		[Export ("majorTickCount")]uint MajorTickCount { get; }

		[Export ("allowZoom")]
		bool AllowZoom { get; set; }

		[Export ("zoom")]
		double Zoom { get; set; }

		[Export ("allowPan")]
		bool AllowPan { get; set; }

		[Export ("pan")]
		double Pan { get; set; }
	}

	[BaseType (typeof(TKChartAxis))]
	public partial interface TKChartNumericAxis
	{
		[Export ("labelDisplayMode")]
		TKChartNumericAxisLabelDisplayMode LabelDisplayMode { get; set; }

		[Export ("majorTickInterval", ArgumentSemantic.Retain)]
		NSNumber MajorTickInterval { get; set; }

		[Export ("minorTickInterval", ArgumentSemantic.Retain)]
		NSNumber MinorTickInterval { get; set; }

		[Export ("baseline", ArgumentSemantic.Retain)]
		NSNumber Baseline { get; set; }

		[Export ("offset", ArgumentSemantic.Retain)]
		NSNumber Offset { get; set; }
	}

	[BaseType (typeof(TKChartAxis))]
	public partial interface TKChartCategoryAxis
	{
		[Export ("valueKeyPath", ArgumentSemantic.Assign)]
		string ValueKeyPath { get; set; }

		[Export ("majorTickInterval")]
		uint MajorTickInterval { get; set; }

		[Export ("minorTickInterval")]
		uint MinorTickInterval { get; set; }

		[Export ("baseline")]
		int Baseline { get; set; }

		[Export ("offset")]
		int Offset { get; set; }

		[Export ("plotMode")]TKChartAxisPlotMode PlotMode { set; }

		[Export ("initWithCategories:")]
		IntPtr Constructor (NSObject[] categories);

		[Export ("initWithCategories:andRange:")]
		IntPtr Constructor (NSObject[] categories, TKRange range);

		[Export ("categories")]
		NSObject [] Categories { get; }

		[Export ("addCategory:")]
		void AddCategory (NSObject category);

		[Export ("addCategoriesFromArray:")]
		void AddCategoriesFromArray (TKChartCategoryAxis[] categories);

		[Export ("removeCategory:")]
		void RemoveCategory (NSObject category);

		[Export ("removeCategoriesInArray:")]
		void RemoveCategoriesInArray ( NSObject[] categories);

		[Export ("removeAllCategories")]
		void RemoveAllCategories ();
	}

	[BaseType (typeof(TKChartAxis))]
	public partial interface TKChartDateTimeAxis
	{
		[Export ("initWithMinimumDate:andMaximumDate:")]
		IntPtr Constructor (NSDate minDate, NSDate maxDate);

		[Export ("majorTickInterval")]
		double MajorTickInterval { get; set; }

		[Export ("majorTickIntervalUnit")]
		TKChartDateTimeAxisIntervalUnit MajorTickIntervalUnit { get; set; }

		[Export ("baseline", ArgumentSemantic.Retain)]
		NSDate Baseline { get; set; }

		[Export ("offset", ArgumentSemantic.Retain)]
		NSDate Offset { get; set; }

		[Export ("plotMode")]
		void SetPlotMode(TKChartAxisPlotMode mode);
	}

	[BaseType (typeof(NSObject))]
	public partial interface TKChartStackInfo
	{
		[Export ("initWithID:withStackMode:")]
		IntPtr Constructor (NSObject aStackID, TKChartStackMode aStackMode);

		[Export ("stackID", ArgumentSemantic.Retain)]
		NSObject StackID { get; set; }

		[Export ("stackMode")]
		TKChartStackMode StackMode { get; set; }
	}

	[BaseType (typeof(TKChartSeries))]
	public partial interface TKChartBarSeries
	{
		[Export ("gapLength")]
		float GapLength { get; set; }
	}

	[BaseType (typeof(TKChartSeries))]
	public partial interface TKChartColumnSeries
	{
		[Export ("gapLength")]
		float GapLength { get; set; }

		[Export ("initWithItems:")]
		IntPtr Constructor (NSObject[] items);
//
//		[Export ("initWithItems:reuseIdentifier:")]
//		IntPtr Constructor (NSObject[] items, string reuseIdentifier);
//
//		[Export ("initWithItems:forKeys:")]
//		IntPtr Constructor (NSObject[] items, NSDictionary keys);
//
//		[Export ("initWithItems:forKeys:reuseIdentifier:")]
//		IntPtr Constructor (NSObject[] items, NSDictionary keys, string reuseIdentifier);
//
//		[Export ("initWithItems:xValueKey:yValueKey:")]
//		IntPtr Constructor (NSObject[] items, string xValueKey, string yValueKey);

	}

	[BaseType (typeof(TKChartSeries))]
	public partial interface TKChartLineSeries
	{
		[Export ("marginForHitDetection")]
		float MarginForHitDetection { get; set; }
	}

	[BaseType (typeof(TKChartSeries))]
	public partial interface TKChartPieSeries
	{
		[Export ("labelFormat", ArgumentSemantic.Retain)]
		string LabelFormat { get; set; }

		[Export ("labelFormatter", ArgumentSemantic.Retain)]
		NSFormatter LabelFormatter { get; set; }

		[Export ("labelStyle", ArgumentSemantic.Retain)]
		TKChartLabelStyle LabelStyle { get; set; }

		[Export ("labelDisplayMode")]
		TKChartPieSeriesLabelDisplayMode LabelDisplayMode { get; set; }

		[Export ("outerRadius")]
		float OuterRadius { get; set; }

		[Export ("expandRadius")]
		float ExpandRadius { get; set; }

		[Export ("startAngle")]
		float StartAngle { get; set; }

		[Export ("endAngle")]
		float EndAngle { get; set; }

		[Export ("rotationAngle")]
		float RotationAngle { get; set; }

		[Export ("selectionAngle", ArgumentSemantic.Retain)]
		NSNumber SelectionAngle { get; set; }

		[Export ("rotationDeceleration")]
		float RotationDeceleration { get; set; }
	}

	[BaseType (typeof(TKChartSeries))]
	public partial interface TKChartScatterSeries
	{
		[Export ("marginForHitDetection")]
		float MarginForHitDetection { get; set; }
	}

	[BaseType (typeof(TKChartPieSeries))]
	public partial interface TKChartDonutSeries
	{
		[Export ("innerRadius")]
		float InnerRadius { get; set; }
	}

	[BaseType (typeof(NSObject))]
	public partial interface TKChartSelectionInfo
	{
		[Static, Export ("hitTestInfoWithSeries:dataPointIndex:")]
		TKChartSelectionInfo HitTestInfoWithSeries (TKChartSeries series, int dataPointIndex);

		[Static, Export ("hitTestInfoWithSeries:dataPointIndex:distance:")]
		TKChartSelectionInfo HitTestInfoWithSeries (TKChartSeries series, int dataPointIndex, float distance);

		[Export ("initWithSeries:dataPointIndex:")]
		IntPtr Constructor (TKChartSeries series, int dataPointIndex);

		[Export ("initWithSeries:dataPointIndex:distance:")]
		IntPtr Constructor (TKChartSeries series, int dataPointIndex, float distance);

		[Export ("series", ArgumentSemantic.Assign)]
		TKChartSeries Series { get; }

		[Export ("dataPointIndex")]
		int DataPointIndex { get; }

		[Export ("dataPoint")]
		TKChartData DataPoint { get; }

		[Export ("distance")]
		float Distance { get; }

		[Export ("location")]PointF Location { get; }
	}

	[BaseType (typeof(UIDynamicItem))]
	public partial interface TKChartVisualPoint //: IUIDynamicItem
	{
		[Export ("initWithPoint:")]
		IntPtr Constructor (PointF point);

		[Export ("CGPoint")]PointF CGPoint { get; }

		[Export ("x")]
		float X { get; set; }

		[Export ("y")]
		float Y { get; set; }

		[Export ("scaleFactor")]
		float ScaleFactor { get; set; }

		[Export ("opacity")]
		float Opacity { get; set; }

		[Export ("center")]
		[Override]
		PointF Center { get; set; }

		[Export ("bounds")]
		[Override]
		RectangleF Bounds { get; }

		[Export ("transform")]
		[Override]
		CGAffineTransform Transform { get; set; }

		[Export ("animator", ArgumentSemantic.Retain)]
		UIDynamicAnimator Animator { get; set; }

		[Export ("doubleValue")]double DoubleValue { get; }
	}

	[BaseType (typeof(TKChartVisualPoint))]
	public partial interface TKChartPieVisualPoint
	{
		[Export ("distanceFromCenter")]
		float DistanceFromCenter { get; set; }

		[Export ("startAngle")]
		float StartAngle { get; set; }
	}

	[BaseType (typeof(NSObject))]
	public partial interface TKChartSeriesRenderState
	{
		[Export ("points", ArgumentSemantic.Retain)]
		TKMutableArray Points { get; set; }

		[Export ("oldPoints", ArgumentSemantic.Retain)]
		TKMutableArray OldPoints { get; }

		[Export ("index")]
		uint Index { get; }

		[Export ("initWithIndex:")]
		IntPtr Constructor (uint index);

		[Export ("animationKeyPathForPointAtIndex:")]
		string AnimationKeyPathForPointAtIndex (uint pointIndex);
	}

	[BaseType (typeof(NSObject))]
	public partial interface TKChartAnnotation
	{
		[Export ("layoutInRect:")]
		void LayoutInRect (RectangleF bounds);

		[Export ("drawInContext:")]
		void DrawInContext (CGContext context);

		[Export ("annotationWasAddedToChart:withLayer:")]
		void AnnotationWasAddedToChart (TKChart chart, CALayer layer);

		[Export ("annotationWillBeRemovedFromChart:")]
		void AnnotationWillBeRemovedFromChart (TKChart chart);

		[Export ("locationOfValue:withAxis:inBounds:")]
		float LocationOfValue (NSObject value, TKChartAxis axis, RectangleF bounds);

		[Export ("hidden")]
		bool Hidden { get; set; }

		[Export ("zPosition")]
		TKChartAnnotationZPosition ZPosition { get; set; }
	}

	[BaseType (typeof(TKChartAnnotation))]
	public partial interface TKChartGridLineAnnotation
	{
		[Export ("initWithValue:forAxis:")]
		IntPtr Constructor (NSObject value, TKChartAxis axis);

		[Export ("initWithValue:forAxis:withStroke:")]
		IntPtr Constructor (NSObject value, TKChartAxis axis, TKStroke stroke);

		[Export ("axis", ArgumentSemantic.Retain)]
		TKChartAxis Axis { get; set; }

		[Export ("value", ArgumentSemantic.Retain)]
		NSObject Value { get; set; }

		[Export ("style", ArgumentSemantic.Retain)]
		TKChartGridLineAnnotationStyle Style { get; }
	}

	[BaseType (typeof(TKChartAnnotation))]
	public partial interface TKChartBandAnnotation
	{
		[Export ("initWithRange:forAxis:")]
		IntPtr Constructor (TKRange aRange, TKChartAxis anAxis);

		[Export ("initWithRange:forAxis:withFill:withStroke:")]
		IntPtr Constructor (TKRange aRange, TKChartAxis anAxis, TKFill fill, TKStroke stroke);

		[Export ("range", ArgumentSemantic.Retain)]
		TKRange Range { get; set; }

		[Export ("axis", ArgumentSemantic.Retain)]
		TKChartAxis Axis { get; set; }

		[Export ("style", ArgumentSemantic.Retain)]
		TKChartBandAnnotationStyle Style { get; }
	}

	[BaseType (typeof(TKChartAnnotation))]
	public partial interface TKChartPointAnnotation
	{
		[Export ("initWithX:Y:forSeries:")]
		IntPtr Constructor (NSObject xValue, NSObject yValue, TKChartSeries series);

		[Export ("initWithPoint:forSeries:")]
		IntPtr Constructor (TKChartData point, TKChartSeries series);

		[Export ("locationInRect:")]
		PointF LocationInRect (RectangleF bounds);

		[Export ("series", ArgumentSemantic.Retain)]
		TKChartSeries Series { get; set; }

		[Export ("position", ArgumentSemantic.Retain)]
		TKChartData Position { get; set; }

		[Export ("offset", ArgumentSemantic.Assign)]
		UIOffset Offset { get; set; }
	}

	[BaseType (typeof(TKChartPointAnnotation))]
	public partial interface TKChartViewAnnotation
	{
		[Export ("initWithView:X:Y:forSeries:")]
		IntPtr Constructor (UIView aView, NSObject xValue, NSObject yValue, TKChartSeries series);

		[Export ("initWithView:point:forSeries:")]
		IntPtr Constructor (UIView aView, TKChartData point, TKChartSeries series);

		[Export ("initWithView:")]
		IntPtr Constructor (UIView aView);

		[Export ("view", ArgumentSemantic.Retain)]
		UIView View { get; set; }
	}

	[BaseType (typeof(TKChartPointAnnotation))]
	public partial interface TKChartLayerAnnotation
	{
		[Export ("initWithLayer:X:Y:forSeries:")]
		IntPtr Constructor (CALayer layer, NSObject xValue, NSObject yValue, TKChartSeries series);

		[Export ("initWithLayer:point:forSeries:")]
		IntPtr Constructor (CALayer layer, TKChartData point, TKChartSeries series);

		[Export ("initWithLayer:")]
		IntPtr Constructor (CALayer layer);

		[Export ("layer", ArgumentSemantic.Retain)]
		CALayer Layer { get; set; }
	}

	[BaseType (typeof(TKChartPointAnnotation))]
	public partial interface TKChartCrossLineAnnotation
	{
		[Export ("style", ArgumentSemantic.Retain)]
		TKChartCrossLineAnnotationStyle Style { get; }
	}

	[BaseType (typeof(TKChartPointAnnotation))]
	public partial interface TKChartBalloonAnnotation
	{
		[Export ("initWithText:X:Y:forSeries:")]
		IntPtr Constructor (string text, NSObject xValue, NSObject yValue, TKChartSeries series);

		[Export ("initWithText:point:forSeries:")]
		IntPtr Constructor (string text, TKChartData point, TKChartSeries series);

		[Export ("initWithText:")]
		IntPtr Constructor (string text);

		[Export ("text", ArgumentSemantic.Retain)]
		string Text { get; set; }

		[Export ("attributedText", ArgumentSemantic.Retain)]
		NSAttributedString AttributedText { get; set; }

		[Export ("view", ArgumentSemantic.Retain)]
		UIView View { get; set; }

		[Export ("size", ArgumentSemantic.Assign)]
		SizeF Size { get; set; }

		[Export ("style", ArgumentSemantic.Retain)]
		TKChartBalloonAnnotationStyle Style { get; }
	}

	[BaseType(typeof(NSObject))]
	public partial interface TKChartAnnotationStyle  {

	}

	[BaseType (typeof(TKChartAnnotationStyle))]
	public partial interface TKChartGridLineAnnotationStyle
	{
		[Export ("stroke", ArgumentSemantic.Retain)]
		TKStroke Stroke { get; set; }
	}

	[BaseType (typeof(TKChartGridLineAnnotationStyle))]
	public partial interface TKChartBandAnnotationStyle
	{
		[Export ("fill", ArgumentSemantic.Retain)]
		TKFill Fill { get; set; }
	}

	[BaseType (typeof(TKChartAnnotationStyle))]
	public partial interface TKChartCrossLineAnnotationStyle
	{
		[Export ("orientation")]
		TKChartCrossLineAnnotationOrientation Orientation { get; set; }

		[Export ("verticalLineStroke", ArgumentSemantic.Retain)]
		TKStroke VerticalLineStroke { get; set; }

		[Export ("horizontalLineStroke", ArgumentSemantic.Retain)]
		TKStroke HorizontalLineStroke { get; set; }

		[Export ("pointShape", ArgumentSemantic.Retain)]
		TKShape PointShape { get; set; }

		[Export ("pointShapeInsets", ArgumentSemantic.Assign)]
		UIEdgeInsets PointShapeInsets { get; set; }

		[Export ("pointShapeFill", ArgumentSemantic.Retain)]
		TKFill PointShapeFill { get; set; }

		[Export ("pointShapeStroke", ArgumentSemantic.Retain)]
		TKStroke PointShapeStroke { get; set; }

		[Export ("insets", ArgumentSemantic.Assign)]
		UIEdgeInsets Insets { get; set; }
	}

	[BaseType (typeof(TKChartAnnotationStyle))]
	public partial interface TKChartBalloonAnnotationStyle
	{
		[Export ("fill", ArgumentSemantic.Retain)]
		TKFill Fill { get; set; }

		[Export ("stroke", ArgumentSemantic.Retain)]
		TKStroke Stroke { get; set; }

		[Export ("font", ArgumentSemantic.Retain)]
		UIFont Font { get; set; }

		[Export ("textColor", ArgumentSemantic.Retain)]
		UIColor TextColor { get; set; }

		[Export ("textAlignment")]
		UITextAlignment TextAlignment { get; set; }

		[Export ("textOrientation")]
		TKChartBalloonAnnotationTextOrientation TextOrientation { get; set; }

		[Export ("insets", ArgumentSemantic.Assign)]
		UIEdgeInsets Insets { get; set; }

		[Export ("verticalAlign")]
		TKChartBalloonVerticalAlignment VerticalAlign { get; set; }

		[Export ("horizontalAlign")]
		TKChartBalloonHorizontalAlignment HorizontalAlign { get; set; }

		[Export ("distanceFromPoint")]
		float DistanceFromPoint { get; set; }

		[Export ("arrowSize", ArgumentSemantic.Assign)]
		SizeF ArrowSize { get; set; }

		[Export ("cornerRadius")]
		float CornerRadius { get; set; }
	}

	[BaseType (typeof(NSObject))]
	public partial interface TKChartTrackball
	{
		[Export ("initWithChart:")]
		IntPtr Constructor (TKChart chart);

		[Export ("showAtPoint:")]
		void ShowAtPoint (PointF point);

		[Export ("hide")]
		void Hide ();

		[Export ("isVisible")]
		bool IsVisible { get; }

		[Export ("line", ArgumentSemantic.Retain)]
		TKChartTrackballLineAnnotation Line { get; }

		[Export ("tooltip", ArgumentSemantic.Retain)]
		TKChartTrackballTooltipAnnotation Tooltip { get; }

		[Export ("snapMode")]
		TKChartTrackballSnapMode SnapMode { get; set; }

		[Export ("orientation")]
		TKChartTrackballOrientation Orientation { get; set; }
	}

	[BaseType (typeof(TKChartAnnotation))]
	public partial interface TKChartTrackballLineAnnotation
	{
		[Export ("initWithTrackball:")]
		IntPtr Constructor (TKChartTrackball trackball);

		[Export ("updateContent")]
		void UpdateContent ();

		[Export ("selectedPoints", ArgumentSemantic.Retain)]NSObject [] SelectedPoints { get; set; }

		[Export ("style", ArgumentSemantic.Retain)]
		TKChartCrossLineAnnotationStyle Style { get; set; }
	}

	[BaseType (typeof(TKChartBalloonAnnotation))]
	public partial interface TKChartTrackballTooltipAnnotation
	{
		[Export ("initWithTrackball:")]
		IntPtr Constructor (TKChartTrackball trackball);

		[Export ("updateContent")]
		void UpdateContent ();

		[Export ("pinPosition")]
		TKChartTrackballPinPosition PinPosition { get; set; }
	}
}
