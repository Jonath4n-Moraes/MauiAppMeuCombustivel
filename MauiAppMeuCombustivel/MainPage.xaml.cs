namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                if(etanol <= (gasolina * 0.7) )
                {
                    msg = "O etanol está compensando.";
                } else
                {
                    msg = "A gasolina está compensado.";
                }

                DisplayAlert("Calculado", msg, "OK");

            } catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }


        } // Fecha Método
    }//Fecha class
}//Fecha namespace
