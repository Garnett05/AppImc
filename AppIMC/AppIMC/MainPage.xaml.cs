using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppIMC
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        public void ActionShowResult (object sender, EventArgs args)
        {
            double weight = double.Parse(entryWeight.Text);
            double height = double.Parse(entryHeight.Text);

            double imc = weight / (height * height);
            lblResult.Text = imc.ToString("N2");
        }
        private void ActionCleanScreen(object sender, EventArgs args)
        {
            App.Current.MainPage = new AppIMC.MainPage();
        }
    }
}
