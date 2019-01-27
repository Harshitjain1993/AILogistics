using MyDjikstra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace MapViewer
{
    public partial class Form1 : Form
    {
        public Map FormMap { get; set; }
        public Form1()
        {
            InitializeComponent();
            Resize += Form1_Resize;
            panel1.Paint += Panel1_Paint;
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (FormMap == null)
                return;
            var g = e.Graphics;
            g.ScaleTransform(0.9f, 0.9f);
            g.TranslateTransform(20, 20);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            var sideX = e.ClipRectangle.Width;
            var sideY = e.ClipRectangle.Height;
            var nodeWidth = 8;
            foreach (var node in FormMap.Nodes)
            {
                var x1 = (node.Point.X * sideX);
                var y1 = (node.Point.Y * sideY);

                var x = x1 - nodeWidth / 2;
                var y = y1 - nodeWidth / 2;
                var brs = Brushes.Black;
                if (node.Visited)
                    brs = Brushes.Red;
                if (node == FormMap.StartNode)
                    brs = Brushes.DarkOrange;
                if (node == FormMap.EndNode)
                    brs = Brushes.Green;
                g.FillEllipse(brs, (float)x, (float)y, nodeWidth, nodeWidth);

                foreach (var cnn in node.Connections)
                {
                    var x2 = (cnn.ConnectedNode.Point.X * sideX);
                    var y2 = (cnn.ConnectedNode.Point.Y * sideY);
                    g.DrawLine(Pens.DarkBlue, (float)x1, (float)y1, (float)x2, (float)y2);
                }
            }
           
            var pen = new Pen(Brushes.YellowGreen, 2);
            for (int i = 0; i < FormMap.ShortestPath.Count - 1; i++)
            {
                var node1 = FormMap.ShortestPath[i];
                var node2 = FormMap.ShortestPath[i + 1];
                var x1 = node1.Point.X * sideX;
                var y1 = node1.Point.Y * sideY;
                var x2 = node2.Point.X * sideX;
                var y2 = node2.Point.Y * sideY;
                g.DrawLine(pen, (float)x1, (float)y1, (float)x2, (float)y2);
            }

            //var font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            //foreach (var node in FormMap.Nodes)
            //{
            //    var x = (node.Point.X * sideX);
            //    var y = (node.Point.Y * sideY);
            //    g.DrawString(node.Name, font, Brushes.Black, (float)x - 4, (float)y - 4);
            //    g.DrawString(node.Name, font, Brushes.Orange, (float)x - 5, (float)y - 5);
            //}
        }
        
        private void DijikstraSearchNewMap()
        {
            richTextBox1.Text = "";
            FormMap = Map.Randomize((int)numericUpDownNodeCount.Value, (int)numericUpDownBranching.Value, (int)numericUpDownSeed.Value,
                cbRandomWeights.Checked);
            var search = new SearchEngine(FormMap);
            search.Updated += Search_Updated;
            var sw = Stopwatch.StartNew();
            FormMap.ShortestPath = search.GetShortestPathDijikstra();
            sw.Stop();
            panel1.Invalidate();
            PrintStats(search, sw);
        }

        private void AstarSearchNewMap()
        {
            richTextBox1.Text = "";
            FormMap = Map.Randomize((int)numericUpDownNodeCount.Value, (int)numericUpDownBranching.Value, (int)numericUpDownSeed.Value,
                cbRandomWeights.Checked);
            var search = new SearchEngine(FormMap);
            search.Updated += Search_Updated;
            var sw = Stopwatch.StartNew();
            FormMap.ShortestPath = search.GetShortestPathAstart();
            sw.Stop();
            PrintStats(search, sw);
            panel1.Invalidate();
            
        }
        private void PrintStats(SearchEngine search, Stopwatch sw)
        {
            richTextBox1.Text = $"Total: {FormMap.Nodes.Count}\r\n" +
                $"Visited {search.NodeVisits}\r\n" +
                $"Time: {sw.Elapsed.TotalMilliseconds}ms\r\n" +
                $"Path length: {search.ShortestPathLength.ToString("0.00")}\r\n" +
                $"Path Cost: {search.ShortestPathCost.ToString("0.00")}";
        }        

        private void Search_Updated(object sender, EventArgs e)
        {
            panel1.Invalidate();
            Application.DoEvents();            
            Thread.Sleep(300);
        }

        private void buttonDjikstra_Click(object sender, EventArgs e)
        {
            DijikstraSearchNewMap();
        }

        private void buttonAstar_Click(object sender, EventArgs e)
        {
            AstarSearchNewMap();
        }
    }
}
