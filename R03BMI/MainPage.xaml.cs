﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        //private double sintyou2;
        double sintyou2;
        double taizyu2;

        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A04 太田愛梨";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
         private void label2_Click(object sender, EventArgs e)
        {

        }
         private void label3_Click(object sender, EventArgs e)
        {

        }
         private void label4_Click(object sender, EventArgs e)
        {

        }
         private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
         private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string sintyou = heighit.Placeholder;
            double s = double.Parse(sintyou);
            string taizyu = weighit.Placeholder;
            double t = double.Parse(taizyu);
           
            if(s > 100)
            {
                sintyou2 = s / 100;
            }
            if(t > 1000)
            {
                taizyu2 =t / 1000;
            }

            double BMI = taizyu2 / sintyou2 * sintyou2;
            //double BMI2 = Math.Round(BMI);
            int BMI2 = (int)BMI;
            double BMI3 = (double)BMI2;
            //result.Text=BMI2.ToString();
            string BMI4=BMI3.ToString();
            result.Text = BMI4;
            //result.Text=BMI2;
        }

    }
}
