Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraCharts
' ...

Namespace CustomPaintEvent
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub chartControl1_CustomPaint(ByVal sender As Object, ByVal e As CustomPaintEventArgs) Handles chartControl1.CustomPaint
			Dim chart As ChartControl = CType(sender, ChartControl)
			Dim series As Series = chart.Series(0)

			Dim screenPoints(series.Points.Count - 1) As Point

			For i As Integer = 0 To series.Points.Count - 1
				screenPoints(i) = (CType(chart.Diagram, XYDiagram2D)).DiagramToPoint(series.Points(i).Argument, series.Points(i).Values(0)).Point
			Next i

			Dim g As Graphics = e.Graphics
			g.SmoothingMode = SmoothingMode.AntiAlias
			g.FillPolygon(New SolidBrush(Color.LightGreen), screenPoints)
			g.DrawPolygon(New Pen(Color.DarkGreen, 2), screenPoints)
		End Sub

	End Class
End Namespace
