using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace graphicsPackage
{

    public partial class TransformForm : Form
    {
        DrawForm mainForm;
        Bitmap originalImage;
        bool imageSelected;
        List<string> transformations = new List<string>();
        List<ListViewItem> transformationsItems = new List<ListViewItem>();

        public TransformForm(DrawForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            setTrackBars();
            setLabels();

            transformationsList.View = View.List; // Set the view mode (e.g., Details, LargeIcon, SmallIcon, List, Tile)
            //transformationsList.Columns.Add("", transformationsList.Width);

            string[] t = { "Rotation", "Scale", "Translation", "Shear"};
            transformations.AddRange(t);
            ListViewItem[] i = { new ListViewItem("Rotation"), new ListViewItem("Scale"), new ListViewItem("Translation"), new ListViewItem("Shear")};
            transformationsItems.AddRange(i);
        }

        private void TransformForm_Load(object sender, EventArgs e)
        {

        }

        /////////////////////////////////////////

        private void btnDraw_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void btnSelectPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                Bitmap image = new Bitmap(selectedImagePath);
                originalImage = image;
                //pictureBox.Image = image;
                imageSelected = true;

                //centerImage();
                fillPictureBox();
            }
        }
        private void btnResetPic_Click(object sender, EventArgs e)
        {
            if (imageSelected)
            {
                //pictureBox.Image = originalImage;
                //centerImage();
                fillPictureBox();
            }

            setTrackBars();
            setLabels();
            transformationsList.Items.Clear();
            rotationBox.Checked = false;
            scaleBox.Checked = false;
            translationBox.Checked = false;
            shearBox.Checked = false;
        }
        private void centerImage()
        {
            int offsetX = (pictureBox.Width - originalImage.Width) / 2;
            int offsetY = (pictureBox.Height - originalImage.Height) / 2;

            // Create a new Bitmap with the size of the PictureBox
            Bitmap centeredImage = new Bitmap(pictureBox.Width, pictureBox.Height);

            // Create a Graphics object from the new Bitmap
            using (Graphics g = Graphics.FromImage(centeredImage))
            {
                // Clear the new Bitmap with a transparent color
                g.Clear(Color.Transparent);

                // Draw the original image at the calculated offset
                g.DrawImage(originalImage, offsetX, offsetY);
            }

            // Assign the centered image to the PictureBox
            pictureBox.Image = centeredImage;
        }
        private void fillPictureBox()
        {
            // Calculate the scaling factors for width and height
            double scaleX = (double)pictureBox.Width / originalImage.Width;
            double scaleY = (double)pictureBox.Height / originalImage.Height;
            double scale = Math.Max(scaleX, scaleY);

            // Calculate the new dimensions for the resized image
            int newWidth = (int)(originalImage.Width * scale);
            int newHeight = (int)(originalImage.Height * scale);

            // Create a new Bitmap with the size of the PictureBox
            Bitmap scaledImage = new Bitmap(pictureBox.Width, pictureBox.Height);

            // Create a Graphics object from the new Bitmap
            using (Graphics g = Graphics.FromImage(scaledImage))
            {
                // Clear the new Bitmap with a transparent color
                g.Clear(Color.Transparent);

                // Calculate the offset to center the resized image within the PictureBox
                int offsetX = (pictureBox.Width - newWidth) / 2;
                int offsetY = (pictureBox.Height - newHeight) / 2;

                // Draw the original image at the calculated offset with the new dimensions
                g.DrawImage(originalImage, offsetX, offsetY, newWidth, newHeight);
            }

            // Assign the scaled image to the PictureBox
            pictureBox.Image = scaledImage;
        }

        /////////////////////////////////////////

        //Initializing Labels & TrackBars
        private void setTrackBars()
        {
            //Set the Initiallization Values for all trackBars
            //Rotation
            rotationBar.Minimum = -90;
            rotationBar.Maximum = 90;
            rotationBar.Value = 0;
            ////////////////////////
            /////Scaling
            /// X
            scaleBarX.Minimum = 5;
            scaleBarX.Maximum = 20;
            scaleBarX.Value = 10;
            /// Y
            scaleBarY.Minimum = 5;
            scaleBarY.Maximum = 20;
            scaleBarY.Value = 10;
            ////////////////////////
            //Translation
            /// X
            translationBarX.Minimum = -100;
            translationBarX.Maximum = 100;
            translationBarX.Value = 0;
            /// Y
            translationBarY.Minimum = -100;
            translationBarY.Maximum = 100;
            translationBarY.Value = 0;
            ////////////////////////
            //Shearing
            /// X
            shearBarX.Minimum = -5;
            shearBarX.Maximum = 5;
            shearBarX.Value = 0;
            /// Y
            shearBarY.Minimum = -5;
            shearBarY.Maximum = 5;
            shearBarY.Value = 0;
            ////////////////////////
        }

        private void setLabels()
        {
            rotationLabel.Text = "0";

            scaleLabelX.Text = "1";
            scaleLabelY.Text = "1";

            shearLabelX.Text = "0";
            shearLabelY.Text = "0";

            translationLabelX.Text = "0";
            translationLabelY.Text = "0";

        }


        /////////////////////////////////////////
        //Scroll Bars

        //Rotation
        private void rotationBar_Scroll(object sender, EventArgs e)
        {
            int value = rotationBar.Value;

            rotationLabel.Text = value.ToString();

            if (rotationBox.Checked)
            {
                if (pictureBox.Image != null)
                {
                    //Bitmap image = (Bitmap)pictureBox.Image;
                    //Bitmap transformedImage = new Bitmap(image.Width, image.Height);

                    //using (Graphics g = Graphics.FromImage(transformedImage))
                    //{
                    //    g.TranslateTransform(image.Width / 2, image.Height / 2); // Translate to center of image
                    //    g.RotateTransform(value); // Rotate by the specified angle
                    //    g.TranslateTransform(-image.Width / 2, -image.Height / 2); // Translate back
                    //    g.InterpolationMode = InterpolationMode.High;
                    //    g.DrawImage(image, 0, 0);// Draw the rotated image

                    //}
                    Bitmap image = (Bitmap)pictureBox.Image;
                    Bitmap transformedImage;
                    Transform t = new Transform(image);
                    //transformedImage = t.Translate(image.Width / 2, image.Height / 2);
                    transformedImage = t.Rotate(value);
                    //transformedImage = t.Translate(-image.Width / 2, -image.Height / 2);

                    pictureBox.Image = transformedImage;
                }
                else
                {
                    MessageBox.Show("Please open an image first.");
                    setLabels();
                    setTrackBars();
                }
            }
        }

        //Scaling
        private void scaleBarX_Scroll(object sender, EventArgs e)
        {
            double value = (double)scaleBarX.Value / 10.0;

            scaleLabelX.Text = value.ToString("0.##");
            if (scaleBox.Checked)
            {
                if (pictureBox.Image != null)
                {
                    Bitmap image = (Bitmap)pictureBox.Image;
                    Transform t = new Transform(image);
                    Bitmap transformedImage = t.Scale(value, 1);

                    pictureBox.Image = transformedImage;
                }
                else
                {
                    MessageBox.Show("Please open an image first.");
                    setLabels();
                    setTrackBars();
                }
            }

        }
        private void scaleBarY_Scroll(object sender, EventArgs e)
        {
            double value = (double)scaleBarY.Value / 10.0;

            scaleLabelY.Text = value.ToString("0.##");
            if (scaleBox.Checked)
            {
                if (pictureBox.Image != null)
                {
                    Bitmap image = (Bitmap)pictureBox.Image;
                    Transform t = new Transform(image);
                    Bitmap transformedImage = t.Scale(1, value);
                    pictureBox.Image = transformedImage;
                }
                else
                {
                    MessageBox.Show("Please open an image first.");
                    setLabels();
                    setTrackBars();
                }
            }

        }

        //Translation
        private void translationBarX_Scroll(object sender, EventArgs e)
        {
            int value = translationBarX.Value;

            translationLabelX.Text = value.ToString();
            if (translationBox.Checked)
            {
                if (pictureBox.Image != null)
                {
                    Bitmap image = (Bitmap)pictureBox.Image;
                    Transform t = new Transform(image);
                    Bitmap transformedImage = t.Translate(value, 0);

                    pictureBox.Image = transformedImage;
                }
                else
                {
                    MessageBox.Show("Please open an image first.");
                    setLabels();
                    setTrackBars();
                }
            }
        }
        private void translationBarY_Scroll(object sender, EventArgs e)
        {
            int value = translationBarY.Value;

            translationLabelY.Text = value.ToString();
            if (translationBox.Checked)
            {
                if (pictureBox.Image != null)
                {
                    Bitmap image = (Bitmap)pictureBox.Image;
                    Transform t = new Transform(image);
                    Bitmap transformedImage = t.Translate(0, value);

                    pictureBox.Image = transformedImage;
                }
                else
                {
                    MessageBox.Show("Please open an image first.");
                    setLabels();
                    setTrackBars();
                }
            }
        }

        //Shearing
        private void shearBarX_Scroll(object sender, EventArgs e)
        {
            double value = shearBarX.Value;

            shearLabelX.Text = value.ToString();
            if (shearBox.Checked)
            {
                if (pictureBox.Image != null)
                {
                    Bitmap image = (Bitmap)pictureBox.Image;
                    Transform t = new Transform(image);
                    Bitmap transformedImage = t.Shear(value, 0);
                    pictureBox.Image = transformedImage;
                }
                else
                {
                    MessageBox.Show("Please open an image first.");
                    setLabels();
                    setTrackBars();
                }
            }
        }

        private void shearBarY_Scroll(object sender, EventArgs e)
        {
            int value = shearBarY.Value;

            shearLabelY.Text = value.ToString();
            if (shearBox.Checked)
            {
                if (pictureBox.Image != null)
                {
                    Bitmap image = (Bitmap)pictureBox.Image;
                    Transform t = new Transform(image);
                    Bitmap transformedImage = t.Shear(0, value);
                    pictureBox.Image = transformedImage;
                }
                else
                {
                    MessageBox.Show("Please open an image first.");
                    setLabels();
                    setTrackBars();
                }
            }
        }


        /////////////////////////////////////////


        //Adding In The List

        private void rotationBox_CheckedChanged(object sender, EventArgs e)
        {
            int index = transformations.IndexOf("Rotation");
            if (rotationBox.Checked)
            {
                transformationsList.Items.Add(transformationsItems[index]);
            }
            else
            {
                transformationsList.Items.Remove(transformationsItems[index]);
            }
        }

        private void scaleBox_CheckedChanged(object sender, EventArgs e)
        {
            int index = transformations.IndexOf("Scale");
            if (scaleBox.Checked)
            {
                transformationsList.Items.Add(transformationsItems[index]);
            }
            else
            {
                transformationsList.Items.Remove(transformationsItems[index]);
            }
        }

        private void translationBox_CheckedChanged(object sender, EventArgs e)
        {
            int index = transformations.IndexOf("Translation");
            if (translationBox.Checked)
            {
                transformationsList.Items.Add(transformationsItems[index]);
            }
            else
            {
                transformationsList.Items.Remove(transformationsItems[index]);
            }
        }

        private void shearBox_CheckedChanged(object sender, EventArgs e)
        {
            int index = transformations.IndexOf("Shear");
            if (shearBox.Checked)
            {
                transformationsList.Items.Add(transformationsItems[index]);
            }
            else
            {
                transformationsList.Items.Remove(transformationsItems[index]);
            }
        }

    }
}
