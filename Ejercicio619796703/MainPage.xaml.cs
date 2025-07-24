namespace Ejercicio619796703
{
    public partial class MainPage : ContentPage
    {
        /// <summary>
        /// Mostramos un entry el cual posee muchas modificaciones, como por ejemplo que los muestre como una contraseña, solo permita hasta un maximo de caracteres y que realize ciertas funciones a la hora de cambiar el texto
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            
        }

		private void Entry_TextChanged(object sender, TextChangedEventArgs e)
		{
            string pasado = e.OldTextValue;
            string nuevo = e.NewTextValue;
        }

		private void Entry_Completed(object sender, EventArgs e)
		{
            string text = ((Entry)sender).Text;
        }
    }

}
