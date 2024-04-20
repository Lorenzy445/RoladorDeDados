namespace RoladorDeDados
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void DiceNumber(object sender, EventArgs e)
        {
            var maxValue = DiceSelect.SelectedItem;
            var sortedNumber = new Random().Next(1, (int)maxValue + 1);

            SortedNumber.Text = sortedNumber.ToString();

            UpdateDiceImage((int)maxValue);

        }
        private void UpdateDiceImage(int numSides)
        {
            string imageName;

            switch (numSides)
            {
                case 4:
                    imageName = "dado_4.png";
                    break;
                case 6:
                    imageName = "dado_6.png";
                    break;
                case 8:
                    imageName = "dado_8.png";
                    break;
                case 10:
                    imageName = "dado_10.png";
                    break;
                case 12:
                    imageName = "dado_12.png";
                    break;
                case 20:
                    imageName = "dado_20.png";
                    break;
                case 100:
                    imageName = "dado_100.png";
                    break;
                default:
                    imageName = "dice_default.png"; // Defina uma imagem padrão para outros valores
                    break;
            }
            test.Source = new FileImageSource { File = imageName };
        }
    }
}
