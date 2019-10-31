using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
namespace ListBox
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Color> Colores = 
            new ObservableCollection<Color>();
        public MainWindow()
        {
            InitializeComponent();
            Colores.Add(new Color("Rojo","#FF0000","255,0,0"));
            Colores.Add(new Color("Verde", "#00FF00", "0,255,0"));
            Colores.Add(new Color("Azul", "#0000FF", "0,0,255"));
            Colores.Add(new Color("Morado", "#6632", "0,0,255"));





            lstColores.ItemsSource = Colores;
        }

        private void BtnNuevoColor_Click(object sender, RoutedEventArgs e)
        {
            new Color(color.Text, Hex.Text, RGB.Text);
            color.Text = "";
            Hex.Text = "";
            RGB.Text = "";            



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lstColores.SelectedIndex != -1)
            {
                Colores.RemoveAt(lstColores.SelectedIndex);
            }
        }

 

        private void LstColores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            nombre_editar.Text =
                 Colores[lstColores.SelectedIndex].Nombre;
            hex_editar.Text =
                 Colores[lstColores.SelectedIndex].Hexadecimal;
            RGB_editar.Text =
                 Colores[lstColores.SelectedIndex].RGB;


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (lstColores.SelectedIndex != -1)
            {
                Colores[lstColores.SelectedIndex].Nombre = txtnombre_ditar.Text;
                Colores[lstColores.SelectedIndex].Hexadecimal = txtehex_editar.Text;
                Colores[lstColores.SelectedIndex].RGB = txtRGB_editar.Text;

            }
        }
    }
}
