namespace BMIDemo
{
    public partial class MainPage : ContentPage
    {
        const double porDebajoDelPeso = 18.5;
        const double pesoNormal = 24.9;
        const double porEncimaDelPeso = 29.9;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var peso = double.Parse(Peso.Text);
            var altura = double.Parse(Altura.Text) / 100; // Conversion de centimetros a metros

            var indice = peso / (altura * altura);

            Indice.Text = indice.ToString("F2"); // Para que salgan solo 2 decimales

            string resultado = MensajeIndice(indice);
            DisplayAlert("Resultado", resultado, "OK");
        }

        private string MensajeIndice(double indice)
        {
            if (indice < porDebajoDelPeso)
            {
                return "Tienes un peso por debajo del normal";
            }
            else if (indice <= pesoNormal)
            {
                return "Tienes un peso Normal";
            }
            else if (indice <= porEncimaDelPeso)
            {
                return "Tienes un peso por encima del normal";
            }
            else
            {
                return "Tienes obesidad, muevete gordo";
            }
           
        }
    }

}
