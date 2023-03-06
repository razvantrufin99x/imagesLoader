using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imagesLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class ImageGallery
        {
            public List<Image> images = new List<Image>();
            public ImageGallery() { }
            public ImageGallery(ImageList images) { }
            public void AddImage(Image image) { images.Add(image); }
            public void RemoveImage(Image image) { images.Remove(image); }
            public Image GetImage(int index) { return images[index]; }
            public int counter = 0;
            public int current = 0;
        }

        public ImageGallery ig = new ImageGallery();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Application.ExecutablePath;
            Image newImage0 = Image.FromFile("listofimages/zero.png");
            ig.counter++;
            Image newImage1 = Image.FromFile("listofimages/unu.png");
            ig.counter++;
            Image newImage2 = Image.FromFile("listofimages/doi.png");

            ig.images.Add(newImage0);
            ig.images.Add(newImage1);
            ig.images.Add(newImage2);

            this.pictureBox1.BackgroundImage = ig.images[0];
            ig.current = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ig.current == 0)
            {
                ig.current = ig.counter;
            }
            else
            {
                ig.current--;
            }
            this.pictureBox1.BackgroundImage = ig.images[ig.current];

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ig.current == ig.counter)
            {
                ig.current = 0;
            }
            else
            {
                ig.current++;
            }
            this.pictureBox1.BackgroundImage = ig.images[ig.current];
        }
    }
}
