using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using org.mariuszgromada.math.mxparser;

namespace Calculadora
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

        public void Calcular(Object sender,EventArgs e)
        {
            Expression eh = new Expression("(2*5)/6+2");
            double resultado = eh.calculate();
            DisplayAlert("Resultado", resultado.ToString(), "OK");
        }
    }

}
