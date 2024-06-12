using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Reflection;

namespace graphicsPackage
{
    public partial class DrawForm : Form
    {
        int maxCoordinate = 500;
        int originX;
        int originY;
        float scale;
        TransformForm tForm;
        panelTransformForm tpForm;

        public DrawForm()
        {
            InitializeComponent();
            tForm = new TransformForm(this);
            tpForm = new panelTransformForm(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Draw X-axis
            int xAxisY = myPanel.Height / 2;
            e.Graphics.DrawLine(Pens.Black, new Point(0, xAxisY), new Point(myPanel.Width, xAxisY));

            // Draw Y-axis
            int yAxisX = myPanel.Width / 2;
            e.Graphics.DrawLine(Pens.Black, new Point(yAxisX, 0), new Point(yAxisX, myPanel.Height));

            setCoordinates();
        }

        private void setCoordinates()
        {
            //Panel is 500*500
            originX = myPanel.Width / 2;
            originY = myPanel.Height / 2;
            scale = (float)CalculateScalingFactor(maxCoordinate, myPanel.Width);
        }

        private void clearPanel_Click(object sender, EventArgs e)
        {
            myPanel.Invalidate();
        }

        //=================================================================//

        //DDA Algorithm
        List<List<float>> lineDDA(int x0, int y0, int xEnd, int yEnd)
        {
            List<List<float>> matrix = new List<List<float>>();

            int dx = xEnd - x0, dy = yEnd - y0, steps, k;

            float xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);

            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;

            //Adding Fisrt Point
            matrix.Add(new List<float>() { -1, x, y });

            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;

                matrix.Add(new List<float>() { k, x, y });
            }
            return matrix;
        }

        private void btnDDA_Click(object sender, EventArgs e)
        {
            if (IsTextBoxEmpty(txtX1) || IsTextBoxEmpty(txtX2) || IsTextBoxEmpty(txtY1) || IsTextBoxEmpty(txtY2))
            {
                MessageBox.Show("Please Fill All Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int.TryParse(txtX1.Text, out int x0);
            int.TryParse(txtY1.Text, out int y0);
            int.TryParse(txtX2.Text, out int x1);
            int.TryParse(txtY2.Text, out int y1);

            int limit = maxCoordinate / 2;
            if (Math.Abs(x0) > limit || Math.Abs(x1) > limit || Math.Abs(y0) > limit || Math.Abs(y1) > limit)
            {
                MessageBox.Show($"Maximum Coordinate is : {limit}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<List<float>> points = lineDDA(x0, y0, x1, y1);

            Brush b = new SolidBrush(colorPanel.BackColor);
            PlotPoints(myPanel, b, points);

            // Write HTML table to file
            List<string> header = new List<string>() { "k", "X", "Y", "(X,Y)" };
            string fileName = "DDA_" + DateTime.Now.ToString("HH-mm-ss") + ".html";
            string title = $"DDA from ({x0},{y0}) to ({x1},{y1})";
            points.RemoveAt(0);
            WriteHtmlTable(fileName, title, points, header);
        }


        //Bresenham Algorithm

        //Only Fisrt Octant
        private List<List<int>> BresenhamLine(int x0, int y0, int xEnd, int yEnd)
        {
            //Just First Octant
            int dx = Math.Abs(xEnd - x0);
            int dy = Math.Abs(yEnd - y0);
            int twoDy = 2 * dy;
            int twoDyMinusDx = 2 * (dy - dx);
            int p = 2 * dy - dx;
            int oldP, x, y;

            if (x0 > xEnd)
            {
                x = xEnd; y = yEnd; xEnd = x0;
            }
            else
            {
                x = x0; y = y0;
            }

            List<List<int>> points = new List<List<int>>();

            //Starting Point
            //{Pk , x, y}

            points.Add(new List<int> { 0, x, y });

            while (x < xEnd)
            {
                ++x;
                oldP = p;
                if (p < 0)
                {
                    p += twoDy;
                }
                else
                {
                    y++;
                    p += twoDyMinusDx;
                }
                points.Add(new List<int> { oldP, x, y });
            }
            return points;
        }

        //All Octants
        private List<List<int>> Bresenham(int x0, int y0, int x1, int y1)
        {
            bool steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            if (steep)
            {
                Swap(ref x0, ref y0);
                Swap(ref x1, ref y1);
            }

            if (x0 > x1)
            {
                Swap(ref x0, ref x1);
                Swap(ref y0, ref y1);
            }

            int dx = x1 - x0;
            int dy = Math.Abs(y1 - y0);
            int constYStep = (y0 < y1) ? 1 : -1;

            List<List<int>> points = new List<List<int>>();

            int y = y0;
            int decisionParam = 2 * dy - dx;
            int oldDecisionParam = 0;
            for (int x = x0; x <= x1; x++)
            {
                points.Add(new List<int>() { oldDecisionParam, steep ? y : x, steep ? x : y });
                oldDecisionParam = decisionParam;

                if (decisionParam > 0)
                {
                    y += constYStep;
                    decisionParam -= 2 * dx;
                }
                decisionParam += 2 * dy;
            }

            return points;
        }

        private void btnBresenham_Click(object sender, EventArgs e)
        {
            if (IsTextBoxEmpty(txtX1) || IsTextBoxEmpty(txtX2) || IsTextBoxEmpty(txtY1) || IsTextBoxEmpty(txtY2))
            {
                MessageBox.Show("Please Fill All Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int.TryParse(txtX1.Text, out int x0);
            int.TryParse(txtY1.Text, out int y0);
            int.TryParse(txtX2.Text, out int x1);
            int.TryParse(txtY2.Text, out int y1);

            int limit = maxCoordinate / 2;
            if (Math.Abs(x0) > limit || Math.Abs(x1) > limit || Math.Abs(y0) > limit || Math.Abs(y1) > limit)
            {
                MessageBox.Show($"Maximum Coordinate is : {limit}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<List<int>> points = Bresenham(x0, y0, x1, y1);

            int indexOfX = points[0].Count - 2;

            Brush b = new SolidBrush(colorPanel.BackColor);

            foreach (List<int> p in points)
            {
                PlotPoint(myPanel, b, p[indexOfX], p[indexOfX + 1]);
            }

            // Write HTML table to file
            List<string> header = new List<string>() { "K", "P<sub>k</sub>", "(X,Y)" };
            string fileName = "Bresenham_" + DateTime.Now.ToString("HH-mm-ss") + ".html";
            string title = $"Bresenham Algorithm from ({x0},{y0}) to ({x1},{y1})";
            points.RemoveAt(0);
            WriteHtmlTable(fileName, title, points, indexOfX, header);
        }


        //Circle Midpoint Algorithm
        private void circlePlotPoint(int xCenter, int yCenter, int x, int y)
        {
            Brush b = new SolidBrush(colorPanel.BackColor);
            PlotPoint(myPanel, b, (xCenter + x), (yCenter + y));
            PlotPoint(myPanel, b, (xCenter - x), (yCenter + y));
            PlotPoint(myPanel, b, (xCenter + x), (yCenter - y));
            PlotPoint(myPanel, b, (xCenter - x), (yCenter - y));

            PlotPoint(myPanel, b, (xCenter + y), (yCenter + x));
            PlotPoint(myPanel, b, (xCenter - y), (yCenter + x));
            PlotPoint(myPanel, b, (xCenter + y), (yCenter - x));
            PlotPoint(myPanel, b, (xCenter - y), (yCenter - x));
        }

        private List<List<int>> circleMidpoint(int xCenter, int yCenter, int radius)
        {
            List<List<int>> matrix = new List<List<int>>();
            int x = 0;
            int y = radius;
            int p = 1 - radius;
            int oldP;
            /*Plot first set of points*/
            matrix.Add(new List<int>() { 0, 2 * (x + xCenter), 2 * (y + yCenter), x, y });

            while (x < y)
            {
                x++;
                oldP = p;
                if (p < 0)
                    p += 2 * x + 1;
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                matrix.Add(new List<int>() { oldP, 2 * (x + xCenter), 2 * (y + yCenter), x, y });
            }
            return matrix;
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            if (IsTextBoxEmpty(txtXCircle) || IsTextBoxEmpty(txtYCircle) || IsTextBoxEmpty(txtCircleRadius))
            {
                MessageBox.Show("Please Fill All Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int.TryParse(txtXCircle.Text, out int x);
            int.TryParse(txtYCircle.Text, out int y);
            int.TryParse(txtCircleRadius.Text, out int r);

            int limit = maxCoordinate / 2;
            if (Math.Abs(x) > limit || Math.Abs(y) > limit)
            {
                MessageBox.Show($"Maximum Coordinate is : {limit}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (r <= 0)
            {
                MessageBox.Show("Raduis Must be Positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (r > limit)
            {
                MessageBox.Show($"Raduis Must be Less Than : {limit}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //{pk , 2(x+xCenter) , 2(y+yCenter) , x , y}
            List<List<int>> points = circleMidpoint(x, y, r);

            //index of y
            int lastElement = points[0].Count - 1;
            int indexOfX = lastElement - 1;
            foreach (List<int> p in points)
            {
                circlePlotPoint(x, y, p[indexOfX], p[lastElement]);
                p[indexOfX] += x;
                p[lastElement] += y;
            }

            List<string> header = new List<string>() { "K", "P<sub>k</sub>", "2X <sub>k+1</sub>", "2Y<sub>k+1</sub>", "(X<sub>k+1</sub>,Y<sub>k+1</sub>)" };
            string fileName = "Circle_" + DateTime.Now.ToString("HH-mm-ss") + ".html";
            string title = $"Circle Algorithm of Center ({x},{y}) and Radius {r}";
            points.RemoveAt(0);
            //points = moveCenter(x,y,points);
            WriteHtmlTable(fileName, title, points, indexOfX, header);
        }


        //Ellipse Algorithm

        private List<List<int>> Ellipse(int rx, int ry)
        {
            List<List<int>> points = new List<List<int>>();
            double dx, dy, d1, d2, x, y;
            x = 0;
            y = ry;

            // Initial decision parameter of region 1
            d1 = (ry * ry) - (rx * rx * ry) + (0.25f * rx * rx);
            dx = 2 * ry * ry * x;
            dy = 2 * rx * rx * y;

            double oldD1 = 0;

            // For region 1
            while (dx < dy)
            {

                points.Add(new List<int>() { (int)oldD1, (int)dx, (int)dy, (int)x, (int)y });
                oldD1 = d1;
                // Checking and updating value of
                // decision parameter based on algorithm
                if (d1 < 0)
                {
                    x++;
                    dx = dx + (2 * ry * ry);
                    d1 = d1 + dx + (ry * ry);
                }
                else
                {
                    x++;
                    y--;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d1 = d1 + dx - dy + (ry * ry);
                }
            }

            // Decision parameter of region 2
            d2 = ((ry * ry) * ((x + 0.5f) * (x + 0.5f))) + ((rx * rx) * ((y - 1) * (y - 1))) - (rx * rx * ry * ry);

            Console.WriteLine(d2);

            // Plotting points of region 2
            while (y >= 0)
            {

                points.Add(new List<int>() { (int)d2, (int)dx, (int)dy, (int)x, (int)y });

                // Checking and updating parameter
                // value based on algorithm
                if (d2 > 0)
                {
                    y--;
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + (rx * rx) - dy;
                }
                else
                {
                    y--;
                    x++;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + dx - dy + (rx * rx);
                }
            }

            return points;
        }
        private void EllipsePlotPoint(int xCenter, int yCenter, int x, int y)
        {
            Brush b = new SolidBrush(colorPanel.BackColor);
            PlotPoint(myPanel, b, (xCenter + x), (yCenter + y));
            PlotPoint(myPanel, b, (xCenter - x), (yCenter + y));
            PlotPoint(myPanel, b, (xCenter + x), (yCenter - y));
            PlotPoint(myPanel, b, (xCenter - x), (yCenter - y));
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            if (IsTextBoxEmpty(txtXCenter) || IsTextBoxEmpty(txtYCenter) || IsTextBoxEmpty(txtXRadius) || IsTextBoxEmpty(txtYRadius))
            {
                MessageBox.Show("Please Fill All Inputs", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int.TryParse(txtXCenter.Text, out int xC);
            int.TryParse(txtYCenter.Text, out int yC);
            int.TryParse(txtXRadius.Text, out int xR);
            int.TryParse(txtYRadius.Text, out int yR);

            int limit = maxCoordinate / 2;
            if (Math.Abs(xC) > limit || Math.Abs(xR) > limit || Math.Abs(yC) > limit || Math.Abs(yR) > limit)
            {
                MessageBox.Show($"Maximum Coordinate is : {maxCoordinate}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (xR < 0 || yR < 0)
            {
                MessageBox.Show("Radius must be Positive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            List<List<int>> points = Ellipse(xR, yR);
            int lastIndex = points[0].Count - 1;
            foreach (List<int> p in points)
            {
                EllipsePlotPoint(xC, yC, p[lastIndex - 1], p[lastIndex]);
            }

            List<string> header = new List<string>() { "K", "Pl<sub>k</sub>", "2r<sup>2</sup><sub>y</sub>x<sub>k+1</sub>", "2r<sup>2</sup><sub>x</sub>y<sub>k+1</sub>", "(X<sub>k+1</sub>,Y<sub>k+1</sub>)" };
            string fileName = "Ellipse_" + DateTime.Now.ToString("HH-mm-ss") + ".html";
            string title = $"Ellipse Algorithm of Center ({xC},{yC}) , X-Radius {xR} and Y-Radius {yR}";
            points.RemoveAt(0);
            WriteHtmlTable(fileName, title, points, lastIndex - 1, header);
        }

        //=================================================================//

        //Helping Functions
        private void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void WriteHtmlTable(string fileName, string title, List<List<float>> points, List<string> header)
        {
            // Create a StreamWriter to write to the file
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Write the beginning of the HTML document
                writer.WriteLine("<!DOCTYPE html>");
                writer.WriteLine("<html>");
                writer.WriteLine("<head>");
                writer.WriteLine("<title>HTML Table</title>");

                // Write CSS styles
                writer.WriteLine("<style>");
                writer.WriteLine("table { width: 100%; border-collapse: collapse; }");
                writer.WriteLine("th, td { padding: 8px; text-align: center; }");
                writer.WriteLine("th { background-color: #f2f2f2; color: #333; }");
                writer.WriteLine("td { background-color: #fff; border: 1px solid #ddd; }");
                writer.WriteLine("</style>");

                writer.WriteLine("</head>");
                writer.WriteLine("<body>");


                writer.WriteLine("<center>");
                writer.WriteLine("<h1>");
                writer.WriteLine($"{title}");
                writer.WriteLine("</h1>");
                writer.WriteLine("</center>");

                // Write the table header
                writer.WriteLine("<table>");
                writer.WriteLine("<tr>");
                foreach (string columnName in header)
                {
                    writer.WriteLine($"<th>{columnName}</th>");
                }
                writer.WriteLine("</tr>");

                // Write the table rows
                foreach (List<float> row in points)
                {
                    writer.WriteLine("<tr>");

                    foreach (float value in row)
                    {
                        writer.WriteLine($"<td>{value}</td>");
                    }

                    int x = (int)Math.Round(row[1]);
                    int y = (int)Math.Round(row[2]);
                    writer.WriteLine($"<td> ({x} , {y})</td>");

                    writer.WriteLine("</tr>");
                }

                // Close the table and HTML document
                writer.WriteLine("</table>");
                writer.WriteLine("</body>");
                writer.WriteLine("</html>");
            }

            Console.WriteLine($"HTML table written to {fileName}");
        }

        private void WriteHtmlTable(string fileName, string title, List<List<int>> points, int indexForX, List<string> header)
        {
            // Create a StreamWriter to write to the file
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                // Write the beginning of the HTML document
                writer.WriteLine("<!DOCTYPE html>");
                writer.WriteLine("<html>");
                writer.WriteLine("<head>");
                writer.WriteLine("<title>HTML Table</title>");

                // Write CSS styles
                writer.WriteLine("<style>");
                writer.WriteLine("table { width: 100%; border-collapse: collapse; }");
                writer.WriteLine("th, td { padding: 8px; text-align: center; }");
                writer.WriteLine("th { background-color: #f2f2f2; color: #333; }");
                writer.WriteLine("td { background-color: #fff; border: 1px solid #ddd; }");
                writer.WriteLine("</style>");

                writer.WriteLine("</head>");
                writer.WriteLine("<body>");

                writer.WriteLine("<center>");
                writer.WriteLine("<h1>");
                writer.WriteLine($"{title}");
                writer.WriteLine("</h1>");
                writer.WriteLine("</center>");

                // Write the table header
                writer.WriteLine("<table>");
                writer.WriteLine("<tr>");
                foreach (string columnName in header)
                {
                    writer.WriteLine($"<th>{columnName}</th>");
                }
                writer.WriteLine("</tr>");

                int k = 0;
                // Write the table rows
                foreach (List<int> row in points)
                {
                    writer.WriteLine("<tr>");

                    writer.WriteLine($"<td>{k}</td>");
                    ++k;
                    for (int i = 0; i < indexForX; ++i)
                    {
                        writer.WriteLine($"<td>{row[i]}</td>");
                    }

                    int x = row[indexForX];
                    int y = row[indexForX + 1];
                    writer.WriteLine($"<td> ({x} , {y})</td>");

                    writer.WriteLine("</tr>");
                }

                // Close the table and HTML document
                writer.WriteLine("</table>");
                writer.WriteLine("</body>");
                writer.WriteLine("</html>");
            }

            Console.WriteLine($"HTML table written to {fileName}");
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

        private void PlotPoints(Panel panel, Brush b, List<List<int>> points)
        {
            using (Graphics g = panel.CreateGraphics())
            {
                int lastIndex = points[0].Count - 1;
                foreach (var point in points)
                {
                    int worldX = point[lastIndex - 1];
                    int worldY = point[lastIndex];

                    // Convert world coordinates to display coordinates
                    int displayX = (int)(originX + worldX * scale);
                    int displayY = (int)(originY - worldY * scale); // Invert Y-axis

                    // Plot point on panel
                    g.FillRectangle(b, displayX, displayY, 2, 2); // Example size
                }
            }
        }

        private void PlotPoints(Panel panel, Brush b, List<List<float>> points)
        {
            using (Graphics g = panel.CreateGraphics())
            {
                foreach (var point in points)
                {
                    int worldX = (int)Math.Round(point[1]);
                    int worldY = (int)Math.Round(point[2]);

                    // Convert world coordinates to display coordinates
                    int displayX = (int)(originX + worldX * scale);
                    int displayY = (int)(originY - worldY * scale); // Invert Y-axis

                    // Plot point on panel
                    g.FillRectangle(b, displayX, displayY, 2, 2); // Example size
                }
            }
        }

        private bool IsTextBoxEmpty(TextBox textBox)
        {
            // Check if the Text property is null or contains only whitespace characters
            return string.IsNullOrWhiteSpace(textBox.Text);
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

        private int getOctant(int x0, int y0, int x1, int y1)
        {
            int dx = x1 - x0;
            int dy = y1 - y0;

            if (dx == 0 || dy == 0)
            {
                throw new ArgumentException("Invalid line: Horizontal or vertical line");
            }
            else if (dx > 0)
            {
                if (dy > 0)
                {
                    return Math.Abs(dx) > Math.Abs(dy) ? 1 : 2;
                }
                else
                {
                    return Math.Abs(dx) > Math.Abs(dy) ? 8 : 7;
                }
            }
            else
            {
                if (dy > 0)
                {
                    return Math.Abs(dx) > Math.Abs(dy) ? 4 : 3;
                }
                else
                {
                    return Math.Abs(dx) > Math.Abs(dy) ? 5 : 6;
                }
            }
        }

        private double CalculateScalingFactor(int maxCoordinate, int panelSize)
        {
            // Determine the scaling factor based on the maximum coordinate and panel size
            double scalingFactor = (double)panelSize / maxCoordinate;
            return scalingFactor;
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            this.Hide();
            tForm.Show();
        }

        private void btnTransformPanel_Click(object sender, EventArgs e)
        {
            this.Hide();
            tpForm.Show();
        }
    }
}
