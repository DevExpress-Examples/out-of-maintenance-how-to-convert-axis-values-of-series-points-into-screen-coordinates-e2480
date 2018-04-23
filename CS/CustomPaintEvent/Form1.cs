using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using DevExpress.XtraCharts;
// ...

namespace CustomPaintEvent {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void chartControl1_CustomPaint(object sender, CustomPaintEventArgs e) {
            ChartControl chart = (ChartControl)sender;
            Series series = chart.Series[0];

            Point[] screenPoints = new Point[series.Points.Count];

            for (int i = 0; i < series.Points.Count; i++) {
                screenPoints[i] =
                    ((XYDiagram2D)chart.Diagram).DiagramToPoint(series.Points[i].Argument,
                    series.Points[i].Values[0]).Point;
            }

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillPolygon(new SolidBrush(Color.LightGreen), screenPoints);
            g.DrawPolygon(new Pen(Color.DarkGreen, 2), screenPoints);
        }

    }
}
