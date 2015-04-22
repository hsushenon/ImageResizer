using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageResizerApp
{
    public partial class ImageResizerForm : Form
    {
        public ImageResizerForm()
        {
            InitializeComponent();

            //to change
            txtSourceDir.Text = @"D:\";//projects\ImageResizerApp\ImageResizerApp\Images";
            txtTargetDir.Text = @"D:\";//projects\ImageResizerApp\ImageResizerApp\Images\resized";
            cmbImageType.SelectedIndex = 0;
        }


        private void btnResize_Click(object sender, EventArgs e)
        {
            try
            {
                string sourceDirectory = txtSourceDir.Text;
                string targetDirectory = txtTargetDir.Text;
                int percentToResize;
                int.TryParse(txtPercentToResize.Text, out percentToResize);
                ImageResize imgr = new ImageResize();
                string message = imgr.ResizeAllImagesInDirectory(sourceDirectory, targetDirectory, percentToResize,cmbImageType.SelectedIndex);
                MessageBox.Show(message);
            }
            catch (Exception)
            {
            
            }
        }
    }
}
