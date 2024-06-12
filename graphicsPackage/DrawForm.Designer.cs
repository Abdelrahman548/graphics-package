namespace graphicsPackage
{
    partial class DrawForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            myPanel = new Panel();
            btnDDA = new Button();
            txtX1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtX2 = new TextBox();
            label3 = new Label();
            txtY2 = new TextBox();
            label4 = new Label();
            txtY1 = new TextBox();
            btnBresenham = new Button();
            clearPanel = new Button();
            label5 = new Label();
            txtYCircle = new TextBox();
            label6 = new Label();
            txtXCircle = new TextBox();
            txtCircleRadius = new TextBox();
            label7 = new Label();
            btnDrawCircle = new Button();
            btnEllipse = new Button();
            label8 = new Label();
            txtXRadius = new TextBox();
            label9 = new Label();
            txtYCenter = new TextBox();
            label10 = new Label();
            txtXCenter = new TextBox();
            label11 = new Label();
            txtYRadius = new TextBox();
            colorPanel = new Panel();
            btnColor = new Button();
            btnTransform = new Button();
            btnTransformPanel = new Button();
            SuspendLayout();
            // 
            // myPanel
            // 
            myPanel.BackColor = Color.FromArgb(255, 255, 128);
            myPanel.Location = new Point(317, 28);
            myPanel.Margin = new Padding(4, 3, 4, 3);
            myPanel.Name = "myPanel";
            myPanel.Size = new Size(500, 500);
            myPanel.TabIndex = 0;
            myPanel.Paint += panel1_Paint;
            // 
            // btnDDA
            // 
            btnDDA.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDDA.Location = new Point(23, 152);
            btnDDA.Margin = new Padding(4, 3, 4, 3);
            btnDDA.Name = "btnDDA";
            btnDDA.Size = new Size(128, 35);
            btnDDA.TabIndex = 1;
            btnDDA.Text = "DDA";
            btnDDA.UseVisualStyleBackColor = true;
            btnDDA.Click += btnDDA_Click;
            // 
            // txtX1
            // 
            txtX1.Location = new Point(54, 82);
            txtX1.Margin = new Padding(4, 3, 4, 3);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(56, 23);
            txtX1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 2;
            label1.Text = "x1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 112);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 4;
            label2.Text = "x2";
            // 
            // txtX2
            // 
            txtX2.Location = new Point(54, 108);
            txtX2.Margin = new Padding(4, 3, 4, 3);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(56, 23);
            txtX2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 112);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 8;
            label3.Text = "y2";
            // 
            // txtY2
            // 
            txtY2.Location = new Point(147, 108);
            txtY2.Margin = new Padding(4, 3, 4, 3);
            txtY2.Name = "txtY2";
            txtY2.Size = new Size(56, 23);
            txtY2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 82);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 6;
            label4.Text = "y1";
            // 
            // txtY1
            // 
            txtY1.Location = new Point(147, 82);
            txtY1.Margin = new Padding(4, 3, 4, 3);
            txtY1.Name = "txtY1";
            txtY1.Size = new Size(56, 23);
            txtY1.TabIndex = 5;
            // 
            // btnBresenham
            // 
            btnBresenham.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBresenham.Location = new Point(176, 152);
            btnBresenham.Margin = new Padding(4, 3, 4, 3);
            btnBresenham.Name = "btnBresenham";
            btnBresenham.Size = new Size(128, 35);
            btnBresenham.TabIndex = 9;
            btnBresenham.Text = "Bresenham";
            btnBresenham.UseVisualStyleBackColor = true;
            btnBresenham.Click += btnBresenham_Click;
            // 
            // clearPanel
            // 
            clearPanel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearPanel.Location = new Point(509, 546);
            clearPanel.Margin = new Padding(4, 3, 4, 3);
            clearPanel.Name = "clearPanel";
            clearPanel.Size = new Size(140, 46);
            clearPanel.TabIndex = 10;
            clearPanel.Text = "Clear Panel";
            clearPanel.UseVisualStyleBackColor = true;
            clearPanel.Click += clearPanel_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 248);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 14;
            label5.Text = "Y Center";
            // 
            // txtYCircle
            // 
            txtYCircle.Location = new Point(94, 240);
            txtYCircle.Margin = new Padding(4, 3, 4, 3);
            txtYCircle.Name = "txtYCircle";
            txtYCircle.Size = new Size(56, 23);
            txtYCircle.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 217);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 12;
            label6.Text = "X Center";
            // 
            // txtXCircle
            // 
            txtXCircle.Location = new Point(94, 209);
            txtXCircle.Margin = new Padding(4, 3, 4, 3);
            txtXCircle.Name = "txtXCircle";
            txtXCircle.Size = new Size(56, 23);
            txtXCircle.TabIndex = 11;
            // 
            // txtCircleRadius
            // 
            txtCircleRadius.Location = new Point(94, 278);
            txtCircleRadius.Margin = new Padding(4, 3, 4, 3);
            txtCircleRadius.Name = "txtCircleRadius";
            txtCircleRadius.Size = new Size(56, 23);
            txtCircleRadius.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 282);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 16;
            label7.Text = "Radius";
            // 
            // btnDrawCircle
            // 
            btnDrawCircle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrawCircle.Location = new Point(176, 240);
            btnDrawCircle.Margin = new Padding(4, 3, 4, 3);
            btnDrawCircle.Name = "btnDrawCircle";
            btnDrawCircle.Size = new Size(128, 35);
            btnDrawCircle.TabIndex = 17;
            btnDrawCircle.Text = "Draw Circle";
            btnDrawCircle.UseVisualStyleBackColor = true;
            btnDrawCircle.Click += btnDrawCircle_Click;
            // 
            // btnEllipse
            // 
            btnEllipse.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEllipse.Location = new Point(97, 450);
            btnEllipse.Margin = new Padding(4, 3, 4, 3);
            btnEllipse.Name = "btnEllipse";
            btnEllipse.Size = new Size(128, 35);
            btnEllipse.TabIndex = 24;
            btnEllipse.Text = "Draw Ellipse";
            btnEllipse.UseVisualStyleBackColor = true;
            btnEllipse.Click += btnEllipse_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 412);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 23;
            label8.Text = "X Radius";
            // 
            // txtXRadius
            // 
            txtXRadius.Location = new Point(94, 408);
            txtXRadius.Margin = new Padding(4, 3, 4, 3);
            txtXRadius.Name = "txtXRadius";
            txtXRadius.Size = new Size(56, 23);
            txtXRadius.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(173, 372);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 21;
            label9.Text = "Y Center";
            // 
            // txtYCenter
            // 
            txtYCenter.Location = new Point(236, 368);
            txtYCenter.Margin = new Padding(4, 3, 4, 3);
            txtYCenter.Name = "txtYCenter";
            txtYCenter.Size = new Size(56, 23);
            txtYCenter.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(26, 372);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 19;
            label10.Text = "X Center";
            // 
            // txtXCenter
            // 
            txtXCenter.Location = new Point(94, 368);
            txtXCenter.Margin = new Padding(4, 3, 4, 3);
            txtXCenter.Name = "txtXCenter";
            txtXCenter.Size = new Size(56, 23);
            txtXCenter.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(173, 412);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 26;
            label11.Text = "Y Radius";
            // 
            // txtYRadius
            // 
            txtYRadius.Location = new Point(236, 408);
            txtYRadius.Margin = new Padding(4, 3, 4, 3);
            txtYRadius.Name = "txtYRadius";
            txtYRadius.Size = new Size(56, 23);
            txtYRadius.TabIndex = 25;
            // 
            // colorPanel
            // 
            colorPanel.BackColor = Color.BlueViolet;
            colorPanel.Location = new Point(74, 14);
            colorPanel.Margin = new Padding(4, 3, 4, 3);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(37, 36);
            colorPanel.TabIndex = 27;
            // 
            // btnColor
            // 
            btnColor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnColor.Location = new Point(136, 23);
            btnColor.Margin = new Padding(4, 3, 4, 3);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(127, 27);
            btnColor.TabIndex = 28;
            btnColor.Text = "Select Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // btnTransform
            // 
            btnTransform.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransform.Location = new Point(11, 537);
            btnTransform.Margin = new Padding(4, 3, 4, 3);
            btnTransform.Name = "btnTransform";
            btnTransform.Size = new Size(140, 46);
            btnTransform.TabIndex = 11;
            btnTransform.Text = "Transform";
            btnTransform.UseVisualStyleBackColor = true;
            btnTransform.Click += btnTransform_Click;
            // 
            // btnTransformPanel
            // 
            btnTransformPanel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransformPanel.Location = new Point(164, 537);
            btnTransformPanel.Margin = new Padding(4, 3, 4, 3);
            btnTransformPanel.Name = "btnTransformPanel";
            btnTransformPanel.Size = new Size(140, 46);
            btnTransformPanel.TabIndex = 29;
            btnTransformPanel.Text = "Transform Panel";
            btnTransformPanel.UseVisualStyleBackColor = true;
            btnTransformPanel.Click += btnTransformPanel_Click;
            // 
            // DrawForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 611);
            Controls.Add(btnTransformPanel);
            Controls.Add(btnTransform);
            Controls.Add(btnColor);
            Controls.Add(colorPanel);
            Controls.Add(label11);
            Controls.Add(txtYRadius);
            Controls.Add(btnEllipse);
            Controls.Add(label8);
            Controls.Add(txtXRadius);
            Controls.Add(label9);
            Controls.Add(txtYCenter);
            Controls.Add(label10);
            Controls.Add(txtXCenter);
            Controls.Add(btnDrawCircle);
            Controls.Add(label7);
            Controls.Add(txtCircleRadius);
            Controls.Add(label5);
            Controls.Add(txtYCircle);
            Controls.Add(label6);
            Controls.Add(txtXCircle);
            Controls.Add(clearPanel);
            Controls.Add(btnBresenham);
            Controls.Add(label3);
            Controls.Add(txtY2);
            Controls.Add(label4);
            Controls.Add(txtY1);
            Controls.Add(label2);
            Controls.Add(txtX2);
            Controls.Add(label1);
            Controls.Add(txtX1);
            Controls.Add(btnDDA);
            Controls.Add(myPanel);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(900, 650);
            MinimizeBox = false;
            MinimumSize = new Size(900, 650);
            Name = "DrawForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Package";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel myPanel;
        private System.Windows.Forms.Button btnDDA;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.Button btnBresenham;
        private System.Windows.Forms.Button clearPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYCircle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtXCircle;
        private System.Windows.Forms.TextBox txtCircleRadius;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDrawCircle;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtXRadius;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYCenter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtXCenter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtYRadius;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Button btnColor;
        private Button btnTransform;
        private Button btnTransformPanel;
    }
}
