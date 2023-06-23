using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace emoyaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
       
    {
        string usuarios;
        public Registro(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text ="Usuario conectado: " + usuario;
            this.usuarios = usuario;
        }

        private void txtInicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtInicial.Text);
                if(dato>1500)
                {
                    DisplayAlert("Abrir ", "Fuera de rango", "Cerrar");
                    txtInicial.Text = " ";
                }
            }
            catch { 
            }   
        }

        private void txtMensual_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

     

        private void bntPago_Clicked_1(object sender, EventArgs e)
        {
            double dato1 = (Convert.ToDouble(txtInicial.Text)-1500);
            double dato2 = (Convert.ToDouble(dato1) * -1);
            double dato3 = (Convert.ToDouble(dato2) / 4);
            double dato4 = (Convert.ToDouble(dato3) * 0.4);
            double dato5 = (Convert.ToDouble(dato4) + dato3);
            

            txtMensual.Text= dato5.ToString();
           
        }

        private void bntResumen_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Resumen());
        }
    }
    
}