﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 4, pictureBox1.Location.Y+4);
                await Task.Delay(50);
                
            }
            for (int i = 0; i < 40; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 4, pictureBox1.Location.Y);
                await Task.Delay(50);
            }
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 4, pictureBox1.Location.Y - 4);
                await Task.Delay(50);
               
            }



        }

        private async void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 4, pictureBox1.Location.Y);
                await Task.Delay(Convert.ToIn

            }
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 4);
                await Task.Delay(Convert.ToInt32(textBox1.Text));
            }
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 4, pictureBox1.Location.Y);
                await Task.Delay(Convert.ToInt32(textBox1.Text));
            }
            for (int i = 0; i < 20; i++)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 4);
                await Task.Delay(Convert.ToInt32(textBox1.Text));
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            while (pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 5, pictureBox1.Location.Y);
                await Task.Delay(100);
            }
            }
                
        
    }
}
