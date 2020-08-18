using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTabuada
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

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(eNumero.Text);
            List<string> itens = new List<string>();
            string texto = "";

            for(int i = 0; i < 11; i++)
            {
                texto = numero + " x " + i + " = " + (numero * i);
                itens.Add(texto);
            }

            LtwTabuada.ItemsSource = itens;
        }
    }
}
