using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMI_Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        void Button_Clicked(object sender, System.EventArgs e)
        {
            double pounds = Convert.ToDouble(In_weight.Text);
            double height = 12 * Convert.ToDouble(In_heightFeet.Text) + (Convert.ToDouble(In_heightInches.Text));

            Out_text.Text = Math.Round((pounds / (height * height) * 703), 1).ToString();
        }
    }
}
