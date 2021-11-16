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
            //double sintyou2;
           // double taizyu2;


      //  string[] zyoutai = new string[2];
           // zyoutai[0] = "(痩せすぎ)";
           // zyoutai[1] = "(痩せ)";
           // BMI[2] = "()";
           // taikan[3] = "(何も感じない)";
           // taikan[4] = "(快適)";
           // taikan[5] = "(不快感を持つ人が出始める)";
           // taikan[6] = "(半数以上が不快に感じる)";
           // taikan[7] = "(全員が不快に感じる)";
            //taikan[8] = "(暑くてたまらない)";

            //double shisu;  
            if(s > 100)
            {
                sintyou2 = s / 100;
            }
            if(t > 1000)
            {
                taizyu2 =t / 1000;
            }

            double BMI = taizyu2 / sintyou2 * sintyou2;
            double BMI2 = Math.Round(BMI);


        }

    }
}
