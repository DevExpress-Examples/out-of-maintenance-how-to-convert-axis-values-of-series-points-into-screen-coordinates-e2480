<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128572957/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2480)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/CustomPaintEvent/Form1.cs) (VB: [Form1.vb](./VB/CustomPaintEvent/Form1.vb))
<!-- default file list end -->
# How to convert axis values of series points into screen coordinates


<p>This example demonstrates how you can obtain screen coordinates of series points (as opposed to their diagram coordinates measured in axis units), and draw a geometric figure across these points.</p><p>This is done in the ChartControl.CustomPaint event handler, by calling the DiagramToPoint method of the chart's XYDiagram2D object.</p>

<br/>


