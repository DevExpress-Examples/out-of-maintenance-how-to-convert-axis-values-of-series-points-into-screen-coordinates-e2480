<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomPaintEvent/Form1.cs) (VB: [Form1.vb](./VB/CustomPaintEvent/Form1.vb))
<!-- default file list end -->
# How to convert axis values of series points into screen coordinates


<p>This example demonstrates how you can obtain screen coordinates of series points (as opposed to their diagram coordinates measured in axis units), and draw a geometric figure across these points.</p><p>This is done in the ChartControl.CustomPaint event handler, by calling the DiagramToPoint method of the chart's XYDiagram2D object.</p>

<br/>


