using _2_Task.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_Task
{
    public partial class Form1 : Form
    {
        //1 = Audio, 2 = Image, 3 = File
        private int chosenOption = 0;
        private string savePath = "";

        // 1 = jpg, 2 = png
        private int chosenImageFormat = 0;

        public Form1()
        {
            InitializeComponent();
            OpenStartScreen();
        }

        private void buttonAudio_Click(object sender, EventArgs e)
        {
            chosenOption = 1;
            OpenConvertingScreen();

        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            chosenOption = 2;
            OpenConvertingScreen();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            chosenOption = 3;
            OpenConvertingScreen();
        }

        private void ClearEverything()
        {
            textBrowsing.Text = "Path to the ";
            textBrowsing.Text += "file";

            imageBox.Image = System.Drawing.Image.FromFile(System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "StartImage.png"));
        }

        private void HideEverything()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Button || c is Label || c is TextBox || c is PictureBox)
                    c.Visible = false;
            }
            tickProvider.Clear();
        }

        private void OpenStartScreen()
        {
            chosenOption = 0;

            HideEverything();

            buttonFile.Visible = true;
            buttonAudio.Visible = true;
            buttonImage.Visible = true;
            labelFile.Visible = true;
            labelImage.Visible = true;
            labelAudio.Visible = true;
            labelStart.Visible = true;
        }

        private void OpenConvertingScreen()
        {
            HideEverything();

            buttonChooseFolder.Visible = true;
            buttonBrowse.Visible = true;
            buttonExit.Visible = true;
            buttonConvert.Visible = true;
            textBrowsing.Visible = true;

            switch (chosenOption)
            {
                case 1:
                    break;
                case 2:
                    imageBox.Visible = true;
                    break;
                case 3:
                    break;
            }

        }

        private void labelImage_Click(object sender, EventArgs e)
        {

        }

        private void labelAudio_Click(object sender, EventArgs e)
        {

        }

        private void labelFile_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            ClearEverything();
            OpenStartScreen();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Choose Image(*.jpg;*.png)|*.jpg;*.png";
            //if ()
            chosenImageFormat = 0;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBrowsing.Text = ofd.InitialDirectory;
                //textBrowsing.Text = ofd.;
                imageBox.Image = System.Drawing.Image.FromFile(ofd.FileName);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (savePath == "")
            {
                errorProvider.SetError(buttonChooseFolder, "Choose path to save");
                return;
            }
            switch (chosenOption)
            {
                case 1:
                    errorProvider.Clear();
                    break;
                case 2:
                    errorProvider.Clear();
                    tickProvider.SetError(buttonConvert, "Nice work");
                    imageBox.Image.Save(savePath + "\\" + imageBox.Name + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    break;
                case 3:
                    errorProvider.Clear();
                    break;
            }
        }

        private void buttonChooseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            savePath = fbd.SelectedPath;
        }
    }
}
