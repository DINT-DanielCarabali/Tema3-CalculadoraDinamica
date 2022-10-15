using System.Windows;
using System.Windows.Controls;

namespace Tema3_Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddButton("1", 2, 0);
            AddButton("2", 2, 1);
            AddButton("3", 2, 2);
            AddButton("4", 3, 0);
            AddButton("5", 3, 1);
            AddButton("6", 3, 2);
            AddButton("7", 4, 0);
            AddButton("8", 4, 1);
            AddButton("9", 4, 2);
        }

        private void AddButton(string content, int row, int column)
        {
            Button button = new Button();
            button.Tag = content;
            TextBlock tb = new TextBlock();
            tb.Text = content;
            Viewbox viewbox = new Viewbox();
            button.Content = viewbox;
            button.Style = (Style)Resources["Botones"];
            viewbox.Child = tb;
            contenedor.Children.Add(button);
            Grid.SetRow(button, row);
            Grid.SetColumn(button, column);
        }

        private void numButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            pantallaTextBlock.Text += button.Tag;
        }
    }
}