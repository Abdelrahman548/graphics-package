using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphicsPackage
{
    public partial class panelTransformForm : Form
    {
        int maxCoordinate = 500;
        int originX;
        int originY;
        float scale;
        List<List<List<int>>> allPoints = new List<List<List<int>>>();
        DrawForm mainForm;

        public panelTransformForm(DrawForm d)
        {
            InitializeComponent();
            this.mainForm = d;
        }

        private void myTransformPanel_Paint(object sender, PaintEventArgs e)
        {
            // Draw X-axis
            int xAxisY = myTransformPanel.Height / 2;
            e.Graphics.DrawLine(Pens.Black, new Point(0, xAxisY), new Point(myTransformPanel.Width, xAxisY));

            // Draw Y-axis
            int yAxisX = myTransformPanel.Width / 2;
            e.Graphics.DrawLine(Pens.Black, new Point(yAxisX, 0), new Point(yAxisX, myTransformPanel.Height));

            setCoordinates();
        }
        private void clearPanel_Click(object sender, EventArgs e)
        {
            myTransformPanel.Invalidate();
            allPoints.Clear();
        }

        private void setCoordinates()
        {
            //Panel is 500*500
            originX = myTransformPanel.Width / 2;
            originY = myTransformPanel.Height / 2;
            scale = (float)CalculateScalingFactor(maxCoordinate, myTransformPanel.Width);
        }

        ///////////////////////////////////
        //DDA Algorithm
        //Drawing Triangle
        List<List<int>> lineDDA(int x0, int y0, int xEnd, int yEnd)
        {
            List<List<int>> matrix = new List<List<int>>();

            int dx = xEnd - x0, dy = yEnd - y0, steps, k;

            float xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);

            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;

            //Adding Fisrt Point
            matrix.Add(new List<int>() { (int)Math.Round(x), (int)Math.Round(y) });

            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;

                matrix.Add(new List<int>() { (int)Math.Round(x), (int)Math.Round(y) });
            }
            return matrix;
        }
        private void btnDrawTriangle_Click(object sender, EventArgs e)
        {
            if (IsTextBoxEmpty(txtX1) || IsTextBoxEmpty(txtX2) || IsTextBoxEmpty(txtX3) || IsTextBoxEmpty(txtY1) || IsTextBoxEmpty(txtY2) || IsTextBoxEmpty(txtY3))
            {
                MessageBox.Show("Please Fill All Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int.TryParse(txtX1.Text, out int x0);
            int.TryParse(txtY1.Text, out int y0);
            int.TryParse(txtX2.Text, out int x1);
            int.TryParse(txtY2.Text, out int y1);
            int.TryParse(txtX3.Text, out int x2);
            int.TryParse(txtY3.Text, out int y2);

            int limit = maxCoordinate / 2;
            if (Math.Abs(x0) > limit || Math.Abs(x1) > limit || Math.Abs(x2) > limit || Math.Abs(y0) > limit || Math.Abs(y1) > limit || Math.Abs(y2) > limit)
            {
                MessageBox.Show($"Maximum Coordinate is : {limit}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            List<List<int>> points1 = lineDDA(x0, y0, x1, y1);
            List<List<int>> points2 = lineDDA(x0, y0, x2, y2);
            List<List<int>> points3 = lineDDA(x1, y1, x2, y2);

            allPoints.Add(points1);
            allPoints.Add(points2);
            allPoints.Add(points3);

            int indexOfX = points1[0].Count - 2;
            Brush b = new SolidBrush(colorPanel.BackColor);

            foreach (List<int> p in points1)
            {
                PlotPoint(myTransformPanel, b, p[indexOfX], p[indexOfX + 1]);
            }
            foreach (List<int> p in points2)
            {
                PlotPoint(myTransformPanel, b, p[indexOfX], p[indexOfX + 1]);
            }
            foreach (List<int> p in points3)
            {
                PlotPoint(myTransformPanel, b, p[indexOfX], p[indexOfX + 1]);
            }


        }

        ///////////////////////////////////
        //Translation
        private void btnTranslate_Click(object sender, EventArgs e)
        {
            if (allPoints.Count == 0)
            {
                MessageBox.Show("Please Draw First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsTextBoxEmpty(txtXTranslate) || IsTextBoxEmpty(txtYTranslate))
            {
                MessageBox.Show("Please Fill All Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int.TryParse(txtXTranslate.Text, out int x);
            int.TryParse(txtYTranslate.Text, out int y);

            PanelTransformation pt = new PanelTransformation(allPoints);
            Brush b = new SolidBrush(colorPanel.BackColor);
            allPoints = pt.Translate(x, y);
            for (int i = 0; i < allPoints.Count; i++)
            {
                for (int j = 0; j < allPoints[i].Count; j++)
                {
                    PlotPoint(myTransformPanel, b, allPoints[i][j][0], allPoints[i][j][1]);
                }
            }
        }

        //Rotation
        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (allPoints.Count == 0)
            {
                MessageBox.Show("Please Draw First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsTextBoxEmpty(txtDegreeRotate))
            {
                MessageBox.Show("Please Fill All Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int.TryParse(txtDegreeRotate.Text, out int degree);

            if (Math.Abs(degree) > 360)
            {
                MessageBox.Show("Maximum Rotation is 360", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PanelTransformation pt = new PanelTransformation(allPoints);
            Brush b = new SolidBrush(colorPanel.BackColor);
            allPoints = pt.Rotate(degree);
            for (int i = 0; i < allPoints.Count; i++)
            {
                for (int j = 0; j < allPoints[i].Count; j++)
                {
                    PlotPoint(myTransformPanel, b, allPoints[i][j][0], allPoints[i][j][1]);
                }
            }
        }

        //Scaling
        private void btnScale_Click(object sender, EventArgs e)
        {
            if (allPoints.Count == 0)
            {
                MessageBox.Show("Please Draw First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsTextBoxEmpty(txtXScale) || IsTextBoxEmpty(txtYScale))
            {
                MessageBox.Show("Please Fill All Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double.TryParse(txtXScale.Text, out double x);
            double.TryParse(txtYScale.Text, out double y);

            PanelTransformation pt = new PanelTransformation(allPoints);
            Brush b = new SolidBrush(colorPanel.BackColor);
            allPoints = pt.Scale(x, y);
            for (int i = 0; i < allPoints.Count; i++)
            {
                for (int j = 0; j < allPoints[i].Count; j++)
                {
                    PlotPoint(myTransformPanel, b, allPoints[i][j][0], allPoints[i][j][1]);
                }
            }
        }

        //Shearing
        private void btnShear_Click(object sender, EventArgs e)
        {
            if (allPoints.Count == 0)
            {
                MessageBox.Show("Please Draw First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IsTextBoxEmpty(txtXShear) || IsTextBoxEmpty(txtYShear))
            {
                MessageBox.Show("Please Fill All Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if( double.TryParse(txtXShear.Text, out double x) && double.TryParse(txtYShear.Text, out double y))
            {
                PanelTransformation pt = new PanelTransformation(allPoints);
                Brush b = new SolidBrush(colorPanel.BackColor);
                allPoints = pt.Shear(x, y);
                for (int i = 0; i < allPoints.Count; i++)
                {
                    for (int j = 0; j < allPoints[i].Count; j++)
                    {
                        PlotPoint(myTransformPanel, b, allPoints[i][j][0], allPoints[i][j][1]);
                    }
                }
            }
        }

        //Reflection
        private void btnXReflect_Click(object sender, EventArgs e)
        {
            if (allPoints.Count == 0)
            {
                MessageBox.Show("Please Draw First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PanelTransformation pt = new PanelTransformation(allPoints);
            Brush b = new SolidBrush(colorPanel.BackColor);
            allPoints = pt.Reflect(1, -1);
            for (int i = 0; i < allPoints.Count; i++)
            {
                for (int j = 0; j < allPoints[i].Count; j++)
                {
                    PlotPoint(myTransformPanel, b, allPoints[i][j][0], allPoints[i][j][1]);
                }
            }
        }

        private void btnYReflect_Click(object sender, EventArgs e)
        {
            if (allPoints.Count == 0)
            {
                MessageBox.Show("Please Draw First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PanelTransformation pt = new PanelTransformation(allPoints);
            Brush b = new SolidBrush(colorPanel.BackColor);
            allPoints = pt.Reflect(-1, 1);
            for (int i = 0; i < allPoints.Count; i++)
            {
                for (int j = 0; j < allPoints[i].Count; j++)
                {
                    PlotPoint(myTransformPanel, b, allPoints[i][j][0], allPoints[i][j][1]);
                }
            }
        }

        private void btnOReflect_Click(object sender, EventArgs e)
        {
            if (allPoints.Count == 0)
            {
                MessageBox.Show("Please Draw First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PanelTransformation pt = new PanelTransformation(allPoints);
            Brush b = new SolidBrush(colorPanel.BackColor);
            allPoints = pt.Reflect(-1, -1);
            for (int i = 0; i < allPoints.Count; i++)
            {
                for (int j = 0; j < allPoints[i].Count; j++)
                {
                    PlotPoint(myTransformPanel, b, allPoints[i][j][0], allPoints[i][j][1]);
                }
            }
        }
        
        ///////////////////////////////////
        private void btnDraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }
        private void PlotPoint(Panel panel, Brush b, int worldX, int worldY)
        {
            using (Graphics g = panel.CreateGraphics())
            {
                // Convert world coordinates to display coordinates
                int displayX = (int)(originX + worldX * scale);
                int displayY = (int)(originY - worldY * scale); // Invert Y-axis

                // Plot point on panel
                g.FillRectangle(b, displayX, displayY, 2, 2); // Example size

            }
        }
        private bool IsTextBoxEmpty(TextBox textBox)
        {
            // Check if the Text property is null or contains only whitespace characters
            return string.IsNullOrWhiteSpace(textBox.Text);
        }
        private double CalculateScalingFactor(int maxCoordinate, int panelSize)
        {
            // Determine the scaling factor based on the maximum coordinate and panel size
            double scalingFactor = (double)panelSize / maxCoordinate;
            return scalingFactor;
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = colorPanel.BackColor;
            cd.FullOpen = true;
            cd.AnyColor = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = cd.Color;
            }
        }
    
    }
}
