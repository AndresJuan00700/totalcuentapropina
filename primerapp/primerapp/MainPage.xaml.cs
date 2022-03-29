using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace primerapp
{
    public partial class MainPage : ContentPage
    {

       
        
        public MainPage()
        {
            InitializeComponent();

           
        }

        private void btn1(object sender, EventArgs e)
        {
           var numeropersonas = double.Parse(personasV.Text);
          var  valorcuenta = double.Parse(valorcuentaV.Text);
          var  propina = double.Parse(propinaV.Text);

          var propinaporcentaje = valorcuenta*propina;
            var valormaspropina = valorcuenta + propinaporcentaje;
            var aporteporpersona = valormaspropina / numeropersonas;
            
            valorpropinaV.Text = propinaporcentaje.ToString();
            valortotalconpropinaV.Text = valormaspropina.ToString();
            aporteporpersonaV.Text = aporteporpersona.ToString();



        }



    }
}
