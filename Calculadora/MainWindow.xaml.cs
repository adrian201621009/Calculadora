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

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
   
        public partial class MainWindow : Window
        {
        private int cantidad1, cantidad2,resultado;
        private string sig;
            public MainWindow()
            {
                InitializeComponent();
            
            uno.Click += Uno_Click;
            dos.Click += Dos_Click;
            tres.Click += Tres_Click;
            cuatro.Click += Cuatro_Click;
            cinco.Click += Cinco_Click;
            seis.Click += Seis_Click;
            siete.Click += Siete_Click;
            ocho.Click += Ocho_Click;
            nueve.Click += Nueve_Click;
            cero.Click += Cero_Click;
            pun.Click += Pun_Click;
            me.Click += Me_Click;
            suma.Click += Suma_Click;
            resta.Click += Resta_Click;
            multiplicacion.Click += Multiplicacion_Click;
            divicioon.Click += Divicioon_Click;
            igual.Click += Igual_Click;
            }

        private void Igual_Click(object sender, RoutedEventArgs e)
        {
            cantidad2 = int.Parse(txtScreen.Text);
            switch (sig)
            {
                case "+":

                    resultado = cantidad1 + cantidad2;
                    txtScreen.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = cantidad1 - cantidad2;
                    txtScreen.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = cantidad1 / cantidad2;
                    txtScreen.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = cantidad1 * cantidad2;
                    txtScreen.Text = resultado.ToString();
                    break;
                   
            }
            
        }

        private void Divicioon_Click(object sender, RoutedEventArgs e)
        {
            sig = "/";
            cantidad1 = int.Parse(txtScreen.Text);
            txtScreen.Clear();
            
        }

        private void Multiplicacion_Click(object sender, RoutedEventArgs e)
        {
            sig = "*";
            cantidad1 = int.Parse(txtScreen.Text);
               txtScreen.Clear();

        }

        private void Resta_Click(object sender, RoutedEventArgs e)
        {
            sig = "-";
            cantidad1 = int.Parse(txtScreen.Text);
            txtScreen.Clear();
        }

        private void Suma_Click(object sender, RoutedEventArgs e)
        {
            sig = "+";
            cantidad1 = int.Parse(txtScreen.Text);
            txtScreen.Clear(); 
        }

        private void Me_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.Clear();
        }

        private void Pun_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.AppendText(pun.Content + "");
        }

        private void Cero_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.AppendText(cero.Content + "");
            
        }

        private void Nueve_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.AppendText(nueve.Content + "");
           
        }

        private void Ocho_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.AppendText(ocho.Content + "");
           
        }

        private void Siete_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.AppendText(siete.Content + "");
            
        }

        private void Seis_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.AppendText(seis.Content + "");
            
        }

        private void Cinco_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.AppendText(cinco.Content + "");
           
            
        }

        private void Cuatro_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.AppendText(cuatro.Content + "");
           
        }

        private void Tres_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.AppendText(tres.Content + "");
            
        }

        private void Dos_Click(object sender, RoutedEventArgs e)
        {
            txtScreen.AppendText(dos.Content + "");
            
        }

        private void Uno_Click(object sender, RoutedEventArgs e)
            {
                txtScreen.AppendText(uno.Content + "");
           
                
            }
        }
    }
