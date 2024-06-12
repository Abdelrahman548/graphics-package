namespace graphicsPackage
{
    partial class TransformForm
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
            btnDraw = new Button();
            pictureBox = new PictureBox();
            btnSelectPic = new Button();
            btnResetPic = new Button();
            rotationBox = new CheckBox();
            rotationBar = new TrackBar();
            scaleBarX = new TrackBar();
            scaleBox = new CheckBox();
            translationBarX = new TrackBar();
            translationBox = new CheckBox();
            shearBarX = new TrackBar();
            shearBox = new CheckBox();
            scaleLabelX = new Label();
            rotationLabel = new Label();
            translationLabelX = new Label();
            shearLabelX = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            scaleLabelY = new Label();
            scaleBarY = new TrackBar();
            label9 = new Label();
            shearLabelY = new Label();
            shearBarY = new TrackBar();
            label11 = new Label();
            translationLabelY = new Label();
            translationBarY = new TrackBar();
            label13 = new Label();
            label14 = new Label();
            transformationsList = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rotationBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scaleBarX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)translationBarX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shearBarX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scaleBarY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shearBarY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)translationBarY).BeginInit();
            SuspendLayout();
            // 
            // btnDraw
            // 
            btnDraw.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDraw.Location = new Point(51, 531);
            btnDraw.Margin = new Padding(4, 3, 4, 3);
            btnDraw.Name = "btnDraw";
            btnDraw.Size = new Size(140, 46);
            btnDraw.TabIndex = 12;
            btnDraw.Text = "<==";
            btnDraw.UseVisualStyleBackColor = true;
            btnDraw.Click += btnDraw_Click;
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(27, 38);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(400, 350);
            pictureBox.TabIndex = 13;
            pictureBox.TabStop = false;
            // 
            // btnSelectPic
            // 
            btnSelectPic.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectPic.Location = new Point(150, 421);
            btnSelectPic.Margin = new Padding(4, 3, 4, 3);
            btnSelectPic.Name = "btnSelectPic";
            btnSelectPic.Size = new Size(140, 46);
            btnSelectPic.TabIndex = 14;
            btnSelectPic.Text = "Select Picture";
            btnSelectPic.UseVisualStyleBackColor = true;
            btnSelectPic.Click += btnSelectPic_Click;
            // 
            // btnResetPic
            // 
            btnResetPic.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetPic.Location = new Point(605, 421);
            btnResetPic.Margin = new Padding(4, 3, 4, 3);
            btnResetPic.Name = "btnResetPic";
            btnResetPic.Size = new Size(140, 46);
            btnResetPic.TabIndex = 15;
            btnResetPic.Text = "Reset";
            btnResetPic.UseVisualStyleBackColor = true;
            btnResetPic.Click += btnResetPic_Click;
            // 
            // rotationBox
            // 
            rotationBox.AutoSize = true;
            rotationBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rotationBox.Location = new Point(495, 29);
            rotationBox.Name = "rotationBox";
            rotationBox.Size = new Size(80, 21);
            rotationBox.TabIndex = 16;
            rotationBox.Text = "Rotation";
            rotationBox.UseVisualStyleBackColor = true;
            rotationBox.CheckedChanged += rotationBox_CheckedChanged;
            // 
            // rotationBar
            // 
            rotationBar.Location = new Point(495, 56);
            rotationBar.Name = "rotationBar";
            rotationBar.Size = new Size(104, 45);
            rotationBar.TabIndex = 17;
            rotationBar.Scroll += rotationBar_Scroll;
            // 
            // scaleBarX
            // 
            scaleBarX.Location = new Point(734, 56);
            scaleBarX.Name = "scaleBarX";
            scaleBarX.Size = new Size(104, 45);
            scaleBarX.TabIndex = 19;
            scaleBarX.Scroll += scaleBarX_Scroll;
            // 
            // scaleBox
            // 
            scaleBox.AutoSize = true;
            scaleBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scaleBox.Location = new Point(734, 29);
            scaleBox.Name = "scaleBox";
            scaleBox.Size = new Size(71, 21);
            scaleBox.TabIndex = 18;
            scaleBox.Text = "Scaling";
            scaleBox.UseVisualStyleBackColor = true;
            scaleBox.CheckedChanged += scaleBox_CheckedChanged;
            // 
            // translationBarX
            // 
            translationBarX.Location = new Point(495, 190);
            translationBarX.Name = "translationBarX";
            translationBarX.Size = new Size(104, 45);
            translationBarX.TabIndex = 21;
            translationBarX.Scroll += translationBarX_Scroll;
            // 
            // translationBox
            // 
            translationBox.AutoSize = true;
            translationBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            translationBox.Location = new Point(495, 163);
            translationBox.Name = "translationBox";
            translationBox.Size = new Size(96, 21);
            translationBox.TabIndex = 20;
            translationBox.Text = "Translation";
            translationBox.UseVisualStyleBackColor = true;
            translationBox.CheckedChanged += translationBox_CheckedChanged;
            // 
            // shearBarX
            // 
            shearBarX.Location = new Point(734, 190);
            shearBarX.Name = "shearBarX";
            shearBarX.Size = new Size(104, 45);
            shearBarX.TabIndex = 23;
            shearBarX.Scroll += shearBarX_Scroll;
            // 
            // shearBox
            // 
            shearBox.AutoSize = true;
            shearBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shearBox.Location = new Point(734, 163);
            shearBox.Name = "shearBox";
            shearBox.Size = new Size(81, 21);
            shearBox.TabIndex = 22;
            shearBox.Text = "Shearing";
            shearBox.UseVisualStyleBackColor = true;
            shearBox.CheckedChanged += shearBox_CheckedChanged;
            // 
            // scaleLabelX
            // 
            scaleLabelX.AutoSize = true;
            scaleLabelX.BackColor = SystemColors.Control;
            scaleLabelX.BorderStyle = BorderStyle.Fixed3D;
            scaleLabelX.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scaleLabelX.Location = new Point(844, 59);
            scaleLabelX.Name = "scaleLabelX";
            scaleLabelX.Size = new Size(17, 19);
            scaleLabelX.TabIndex = 27;
            scaleLabelX.Text = "0";
            // 
            // rotationLabel
            // 
            rotationLabel.AutoSize = true;
            rotationLabel.BackColor = SystemColors.Control;
            rotationLabel.BorderStyle = BorderStyle.Fixed3D;
            rotationLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rotationLabel.Location = new Point(605, 59);
            rotationLabel.Name = "rotationLabel";
            rotationLabel.Size = new Size(17, 19);
            rotationLabel.TabIndex = 28;
            rotationLabel.Text = "0";
            // 
            // translationLabelX
            // 
            translationLabelX.AutoSize = true;
            translationLabelX.BackColor = SystemColors.Control;
            translationLabelX.BorderStyle = BorderStyle.Fixed3D;
            translationLabelX.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            translationLabelX.Location = new Point(605, 190);
            translationLabelX.Name = "translationLabelX";
            translationLabelX.Size = new Size(17, 19);
            translationLabelX.TabIndex = 29;
            translationLabelX.Text = "0";
            // 
            // shearLabelX
            // 
            shearLabelX.AutoSize = true;
            shearLabelX.BackColor = SystemColors.Control;
            shearLabelX.BorderStyle = BorderStyle.Fixed3D;
            shearLabelX.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shearLabelX.Location = new Point(844, 190);
            shearLabelX.Name = "shearLabelX";
            shearLabelX.Size = new Size(17, 19);
            shearLabelX.TabIndex = 30;
            shearLabelX.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(438, 59);
            label5.Name = "label5";
            label5.Size = new Size(51, 17);
            label5.TabIndex = 31;
            label5.Text = "Degree";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(690, 61);
            label6.Name = "label6";
            label6.Size = new Size(14, 15);
            label6.TabIndex = 32;
            label6.Text = "X";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(690, 112);
            label7.Name = "label7";
            label7.Size = new Size(14, 15);
            label7.TabIndex = 35;
            label7.Text = "Y";
            // 
            // scaleLabelY
            // 
            scaleLabelY.AutoSize = true;
            scaleLabelY.BackColor = SystemColors.Control;
            scaleLabelY.BorderStyle = BorderStyle.Fixed3D;
            scaleLabelY.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scaleLabelY.Location = new Point(844, 110);
            scaleLabelY.Name = "scaleLabelY";
            scaleLabelY.Size = new Size(17, 19);
            scaleLabelY.TabIndex = 34;
            scaleLabelY.Text = "0";
            // 
            // scaleBarY
            // 
            scaleBarY.Location = new Point(734, 107);
            scaleBarY.Name = "scaleBarY";
            scaleBarY.Size = new Size(104, 45);
            scaleBarY.TabIndex = 33;
            scaleBarY.Scroll += scaleBarY_Scroll;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(690, 246);
            label9.Name = "label9";
            label9.Size = new Size(14, 15);
            label9.TabIndex = 38;
            label9.Text = "Y";
            // 
            // shearLabelY
            // 
            shearLabelY.AutoSize = true;
            shearLabelY.BackColor = SystemColors.Control;
            shearLabelY.BorderStyle = BorderStyle.Fixed3D;
            shearLabelY.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shearLabelY.Location = new Point(844, 244);
            shearLabelY.Name = "shearLabelY";
            shearLabelY.Size = new Size(17, 19);
            shearLabelY.TabIndex = 37;
            shearLabelY.Text = "0";
            // 
            // shearBarY
            // 
            shearBarY.Location = new Point(734, 241);
            shearBarY.Name = "shearBarY";
            shearBarY.Size = new Size(104, 45);
            shearBarY.TabIndex = 36;
            shearBarY.Scroll += shearBarY_Scroll;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(451, 246);
            label11.Name = "label11";
            label11.Size = new Size(14, 15);
            label11.TabIndex = 41;
            label11.Text = "Y";
            // 
            // translationLabelY
            // 
            translationLabelY.AutoSize = true;
            translationLabelY.BackColor = SystemColors.Control;
            translationLabelY.BorderStyle = BorderStyle.Fixed3D;
            translationLabelY.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            translationLabelY.Location = new Point(605, 244);
            translationLabelY.Name = "translationLabelY";
            translationLabelY.Size = new Size(17, 19);
            translationLabelY.TabIndex = 40;
            translationLabelY.Text = "0";
            // 
            // translationBarY
            // 
            translationBarY.Location = new Point(495, 241);
            translationBarY.Name = "translationBarY";
            translationBarY.Size = new Size(104, 45);
            translationBarY.TabIndex = 39;
            translationBarY.Scroll += translationBarY_Scroll;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(690, 194);
            label13.Name = "label13";
            label13.Size = new Size(14, 15);
            label13.TabIndex = 42;
            label13.Text = "X";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(451, 192);
            label14.Name = "label14";
            label14.Size = new Size(14, 15);
            label14.TabIndex = 43;
            label14.Text = "X";
            // 
            // transformationsList
            // 
            transformationsList.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            transformationsList.Location = new Point(575, 292);
            transformationsList.Name = "transformationsList";
            transformationsList.Size = new Size(200, 100);
            transformationsList.TabIndex = 44;
            transformationsList.UseCompatibleStateImageBehavior = false;
            // 
            // TransformForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 611);
            ControlBox = false;
            Controls.Add(transformationsList);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(translationLabelY);
            Controls.Add(translationBarY);
            Controls.Add(label9);
            Controls.Add(shearLabelY);
            Controls.Add(shearBarY);
            Controls.Add(label7);
            Controls.Add(scaleLabelY);
            Controls.Add(scaleBarY);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(shearLabelX);
            Controls.Add(translationLabelX);
            Controls.Add(rotationLabel);
            Controls.Add(scaleLabelX);
            Controls.Add(shearBarX);
            Controls.Add(shearBox);
            Controls.Add(translationBarX);
            Controls.Add(translationBox);
            Controls.Add(scaleBarX);
            Controls.Add(scaleBox);
            Controls.Add(rotationBar);
            Controls.Add(rotationBox);
            Controls.Add(btnResetPic);
            Controls.Add(btnSelectPic);
            Controls.Add(pictureBox);
            Controls.Add(btnDraw);
            MaximizeBox = false;
            MaximumSize = new Size(900, 650);
            MinimizeBox = false;
            MinimumSize = new Size(900, 650);
            Name = "TransformForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransformForm";
            Load += TransformForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)rotationBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)scaleBarX).EndInit();
            ((System.ComponentModel.ISupportInitialize)translationBarX).EndInit();
            ((System.ComponentModel.ISupportInitialize)shearBarX).EndInit();
            ((System.ComponentModel.ISupportInitialize)scaleBarY).EndInit();
            ((System.ComponentModel.ISupportInitialize)shearBarY).EndInit();
            ((System.ComponentModel.ISupportInitialize)translationBarY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDraw;
        private PictureBox pictureBox;
        private Button btnSelectPic;
        private Button btnResetPic;
        private CheckBox rotationBox;
        private TrackBar rotationBar;
        private TrackBar scaleBarX;
        private CheckBox scaleBox;
        private TrackBar translationBarX;
        private CheckBox translationBox;
        private TrackBar shearBarX;
        private CheckBox shearBox;
        private Label scaleLabelX;
        private Label rotationLabel;
        private Label translationLabelX;
        private Label shearLabelX;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label scaleLabelY;
        private TrackBar scaleBarY;
        private Label label9;
        private Label shearLabelY;
        private TrackBar shearBarY;
        private Label label11;
        private Label translationLabelY;
        private TrackBar translationBarY;
        private Label label13;
        private Label label14;
        private ListView transformationsList;
    }
}