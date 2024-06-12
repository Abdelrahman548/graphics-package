namespace graphicsPackage
{
    partial class panelTransformForm
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
            myTransformPanel = new Panel();
            clearPanel = new Button();
            btnDraw = new Button();
            label3 = new Label();
            txtY2 = new TextBox();
            label4 = new Label();
            txtY1 = new TextBox();
            label2 = new Label();
            txtX2 = new TextBox();
            label1 = new Label();
            txtX1 = new TextBox();
            btnDrawTriangle = new Button();
            label5 = new Label();
            txtY3 = new TextBox();
            label6 = new Label();
            txtX3 = new TextBox();
            btnColor = new Button();
            colorPanel = new Panel();
            label7 = new Label();
            txtYTranslate = new TextBox();
            label8 = new Label();
            txtXTranslate = new TextBox();
            btnTranslate = new Button();
            btnScale = new Button();
            label9 = new Label();
            txtYScale = new TextBox();
            label10 = new Label();
            txtXScale = new TextBox();
            btnShear = new Button();
            label11 = new Label();
            txtYShear = new TextBox();
            label12 = new Label();
            txtXShear = new TextBox();
            btnRotate = new Button();
            label14 = new Label();
            txtDegreeRotate = new TextBox();
            btnXReflect = new Button();
            btnYReflect = new Button();
            btnOReflect = new Button();
            SuspendLayout();
            // 
            // myTransformPanel
            // 
            myTransformPanel.BackColor = Color.FromArgb(255, 255, 128);
            myTransformPanel.Location = new Point(371, 42);
            myTransformPanel.Margin = new Padding(4, 3, 4, 3);
            myTransformPanel.Name = "myTransformPanel";
            myTransformPanel.Size = new Size(500, 500);
            myTransformPanel.TabIndex = 1;
            myTransformPanel.Paint += myTransformPanel_Paint;
            // 
            // clearPanel
            // 
            clearPanel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearPanel.Location = new Point(554, 553);
            clearPanel.Margin = new Padding(4, 3, 4, 3);
            clearPanel.Name = "clearPanel";
            clearPanel.Size = new Size(140, 46);
            clearPanel.TabIndex = 11;
            clearPanel.Text = "Clear Panel";
            clearPanel.UseVisualStyleBackColor = true;
            clearPanel.Click += clearPanel_Click;
            // 
            // btnDraw
            // 
            btnDraw.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDraw.Location = new Point(41, 553);
            btnDraw.Margin = new Padding(4, 3, 4, 3);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(140, 46);
            btnDraw.TabIndex = 13;
            btnDraw.Text = "<==";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 99);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 22;
            label3.Text = "y2";
            // 
            // txtY2
            // 
            txtY2.Location = new Point(153, 95);
            txtY2.Margin = new Padding(4, 3, 4, 3);
            txtY2.Name = "txtY2";
            txtY2.Size = new Size(56, 23);
            txtY2.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 69);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 20;
            label4.Text = "y1";
            // 
            // txtY1
            // 
            txtY1.Location = new Point(153, 69);
            txtY1.Margin = new Padding(4, 3, 4, 3);
            txtY1.Name = "txtY1";
            txtY1.Size = new Size(56, 23);
            txtY1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 18;
            label2.Text = "x2";
            // 
            // txtX2
            // 
            txtX2.Location = new Point(60, 95);
            txtX2.Margin = new Padding(4, 3, 4, 3);
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(56, 23);
            txtX2.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 69);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 16;
            label1.Text = "x1";
            // 
            // txtX1
            // 
            txtX1.Location = new Point(60, 69);
            txtX1.Margin = new Padding(4, 3, 4, 3);
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(56, 23);
            txtX1.TabIndex = 14;
            // 
            // btnDrawTriangle
            // 
            btnDrawTriangle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDrawTriangle.Location = new Point(72, 153);
            btnDrawTriangle.Margin = new Padding(4, 3, 4, 3);
            btnDrawTriangle.Name = "btnDrawTriangle";
            btnDrawTriangle.Size = new Size(128, 35);
            btnDrawTriangle.TabIndex = 15;
            btnDrawTriangle.Text = "Draw";
            btnDrawTriangle.UseVisualStyleBackColor = true;
            btnDrawTriangle.Click += btnDrawTriangle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 128);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 26;
            label5.Text = "y3";
            // 
            // txtY3
            // 
            txtY3.Location = new Point(153, 124);
            txtY3.Margin = new Padding(4, 3, 4, 3);
            txtY3.Name = "txtY3";
            txtY3.Size = new Size(56, 23);
            txtY3.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 128);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(19, 15);
            label6.TabIndex = 24;
            label6.Text = "x3";
            // 
            // txtX3
            // 
            txtX3.Location = new Point(60, 124);
            txtX3.Margin = new Padding(4, 3, 4, 3);
            txtX3.Name = "txtX3";
            txtX3.Size = new Size(56, 23);
            txtX3.TabIndex = 23;
            // 
            // btnColor
            // 
            btnColor.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnColor.Location = new Point(125, 21);
            btnColor.Margin = new Padding(4, 3, 4, 3);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(127, 27);
            btnColor.TabIndex = 30;
            btnColor.Text = "Select Color";
            btnColor.UseVisualStyleBackColor = true;
            btnColor.Click += btnColor_Click;
            // 
            // colorPanel
            // 
            colorPanel.BackColor = Color.BlueViolet;
            colorPanel.Location = new Point(63, 12);
            colorPanel.Margin = new Padding(4, 3, 4, 3);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(37, 36);
            colorPanel.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(125, 219);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 34;
            label7.Text = "y1";
            // 
            // txtYTranslate
            // 
            txtYTranslate.Location = new Point(153, 219);
            txtYTranslate.Margin = new Padding(4, 3, 4, 3);
            txtYTranslate.Name = "txtYTranslate";
            txtYTranslate.Size = new Size(56, 23);
            txtYTranslate.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 219);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(19, 15);
            label8.TabIndex = 32;
            label8.Text = "x1";
            // 
            // txtXTranslate
            // 
            txtXTranslate.Location = new Point(60, 219);
            txtXTranslate.Margin = new Padding(4, 3, 4, 3);
            txtXTranslate.Name = "txtXTranslate";
            txtXTranslate.Size = new Size(56, 23);
            txtXTranslate.TabIndex = 31;
            // 
            // btnTranslate
            // 
            btnTranslate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTranslate.Location = new Point(217, 212);
            btnTranslate.Margin = new Padding(4, 3, 4, 3);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(128, 35);
            btnTranslate.TabIndex = 35;
            btnTranslate.Text = "Translate";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // btnScale
            // 
            btnScale.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnScale.Location = new Point(217, 269);
            btnScale.Margin = new Padding(4, 3, 4, 3);
            btnScale.Name = "btnScale";
            btnScale.Size = new Size(128, 35);
            btnScale.TabIndex = 40;
            btnScale.Text = "Scale";
            btnScale.UseVisualStyleBackColor = true;
            btnScale.Click += btnScale_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(125, 276);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 39;
            label9.Text = "y1";
            // 
            // txtYScale
            // 
            txtYScale.Location = new Point(153, 276);
            txtYScale.Margin = new Padding(4, 3, 4, 3);
            txtYScale.Name = "txtYScale";
            txtYScale.Size = new Size(56, 23);
            txtYScale.TabIndex = 38;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(32, 276);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(19, 15);
            label10.TabIndex = 37;
            label10.Text = "x1";
            // 
            // txtXScale
            // 
            txtXScale.Location = new Point(60, 276);
            txtXScale.Margin = new Padding(4, 3, 4, 3);
            txtXScale.Name = "txtXScale";
            txtXScale.Size = new Size(56, 23);
            txtXScale.TabIndex = 36;
            // 
            // btnShear
            // 
            btnShear.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShear.Location = new Point(217, 326);
            btnShear.Margin = new Padding(4, 3, 4, 3);
            btnShear.Name = "btnShear";
            btnShear.Size = new Size(128, 35);
            btnShear.TabIndex = 45;
            btnShear.Text = "Shear";
            btnShear.UseVisualStyleBackColor = true;
            btnShear.Click += btnShear_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(125, 333);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 44;
            label11.Text = "y1";
            // 
            // txtYShear
            // 
            txtYShear.Location = new Point(153, 333);
            txtYShear.Margin = new Padding(4, 3, 4, 3);
            txtYShear.Name = "txtYShear";
            txtYShear.Size = new Size(56, 23);
            txtYShear.TabIndex = 43;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(32, 333);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(19, 15);
            label12.TabIndex = 42;
            label12.Text = "x1";
            // 
            // txtXShear
            // 
            txtXShear.Location = new Point(60, 333);
            txtXShear.Margin = new Padding(4, 3, 4, 3);
            txtXShear.Name = "txtXShear";
            txtXShear.Size = new Size(56, 23);
            txtXShear.TabIndex = 41;
            // 
            // btnRotate
            // 
            btnRotate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRotate.Location = new Point(217, 376);
            btnRotate.Margin = new Padding(4, 3, 4, 3);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(128, 35);
            btnRotate.TabIndex = 50;
            btnRotate.Text = "Rotate";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(72, 386);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(44, 15);
            label14.TabIndex = 47;
            label14.Text = "Degree";
            // 
            // txtDegreeRotate
            // 
            txtDegreeRotate.Location = new Point(125, 383);
            txtDegreeRotate.Margin = new Padding(4, 3, 4, 3);
            txtDegreeRotate.Name = "txtDegreeRotate";
            txtDegreeRotate.Size = new Size(56, 23);
            txtDegreeRotate.TabIndex = 46;
            // 
            // btnXReflect
            // 
            btnXReflect.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXReflect.Location = new Point(41, 430);
            btnXReflect.Margin = new Padding(4, 3, 4, 3);
            btnXReflect.Name = "btnXReflect";
            btnXReflect.Size = new Size(128, 35);
            btnXReflect.TabIndex = 51;
            btnXReflect.Text = "Reflect X-axis";
            btnXReflect.UseVisualStyleBackColor = true;
            btnXReflect.Click += btnXReflect_Click;
            // 
            // btnYReflect
            // 
            btnYReflect.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYReflect.Location = new Point(207, 430);
            btnYReflect.Margin = new Padding(4, 3, 4, 3);
            btnYReflect.Name = "btnYReflect";
            btnYReflect.Size = new Size(128, 35);
            btnYReflect.TabIndex = 52;
            btnYReflect.Text = "Reflect Y-axis";
            btnYReflect.UseVisualStyleBackColor = true;
            btnYReflect.Click += btnYReflect_Click;
            // 
            // btnOReflect
            // 
            btnOReflect.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOReflect.Location = new Point(125, 489);
            btnOReflect.Margin = new Padding(4, 3, 4, 3);
            btnOReflect.Name = "btnOReflect";
            btnOReflect.Size = new Size(128, 35);
            btnOReflect.TabIndex = 53;
            btnOReflect.Text = "Reflect Origin";
            btnOReflect.UseVisualStyleBackColor = true;
            btnOReflect.Click += btnOReflect_Click;
            // 
            // panelTransformForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 611);
            ControlBox = false;
            Controls.Add(btnOReflect);
            Controls.Add(btnYReflect);
            Controls.Add(btnXReflect);
            Controls.Add(btnRotate);
            Controls.Add(label14);
            Controls.Add(txtDegreeRotate);
            Controls.Add(btnShear);
            Controls.Add(label11);
            Controls.Add(txtYShear);
            Controls.Add(label12);
            Controls.Add(txtXShear);
            Controls.Add(btnScale);
            Controls.Add(label9);
            Controls.Add(txtYScale);
            Controls.Add(label10);
            Controls.Add(txtXScale);
            Controls.Add(btnTranslate);
            Controls.Add(label7);
            Controls.Add(txtYTranslate);
            Controls.Add(label8);
            Controls.Add(txtXTranslate);
            Controls.Add(btnColor);
            Controls.Add(colorPanel);
            Controls.Add(label5);
            Controls.Add(txtY3);
            Controls.Add(label6);
            Controls.Add(txtX3);
            Controls.Add(label3);
            Controls.Add(txtY2);
            Controls.Add(label4);
            Controls.Add(txtY1);
            Controls.Add(label2);
            Controls.Add(txtX2);
            Controls.Add(label1);
            Controls.Add(txtX1);
            Controls.Add(btnDrawTriangle);
            Controls.Add(btnDraw);
            Controls.Add(clearPanel);
            Controls.Add(myTransformPanel);
            MaximizeBox = false;
            MaximumSize = new Size(900, 650);
            MinimizeBox = false;
            MinimumSize = new Size(900, 650);
            Name = "panelTransformForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Panel Transform";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel myTransformPanel;
        private Button clearPanel;
        private Button btnDraw;
        private Label label3;
        private TextBox txtY2;
        private Label label4;
        private TextBox txtY1;
        private Label label2;
        private TextBox txtX2;
        private Label label1;
        private TextBox txtX1;
        private Button btnDrawTriangle;
        private Label label5;
        private TextBox txtY3;
        private Label label6;
        private TextBox txtX3;
        private Button btnColor;
        private Panel colorPanel;
        private Label label7;
        private TextBox txtYTranslate;
        private Label label8;
        private TextBox txtXTranslate;
        private Button btnTranslate;
        private Button btnScale;
        private Label label9;
        private TextBox txtYScale;
        private Label label10;
        private TextBox txtXScale;
        private Button btnShear;
        private Label label11;
        private TextBox txtYShear;
        private Label label12;
        private TextBox txtXShear;
        private Button btnRotate;
        private Label label14;
        private TextBox txtDegreeRotate;
        private Button btnXReflect;
        private Button btnYReflect;
        private Button btnOReflect;
    }
}