using System;
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
        //double h;
        //double taizyu2;

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
           
            try
            {
                string height = heighit.Text;
                string weight = weighit.Text;

                double height2 = double.Parse(height);
                double weight2 = double.Parse(weight);
                   
      
                if (height2 >= 10)
                {
                    height2 = height2 / 100;
                }
                if (weight2 >= 1000)
                {
                    weight2 = weight2 / 1000;
                }
                
                double BMI = weight2 / (height2 * height2);
                double BMI2 = Math.Round(BMI);
                //string BMI3 = BMI2.ToString();
                
               
                result.Text = "BMI値は"+ BMI2 +"です。";
                Console.WriteLine(BMI2);
                
                //result.Text=BMI2.ToString();
                
               
                //result.Text=BMI2;
              
            }
            catch(FormatException ex)
            {
                
                result.Text =ex.Message;
                Console.WriteLine(ex.Message);
                
            }
            
            
        }

    }
}
