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

namespace Convert_String_to_Number
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            displayText.Text = "";
            this.displayText.Text += typeText.Text;
        }

        private void Button_Copy(object sender, RoutedEventArgs e)
        {

            Clipboard.SetText(typeText.Text);
            displayText.Text = "Copied!";



        }

        private void Button_Cut(object sender, RoutedEventArgs e)
        {
            
            Clipboard.SetText(typeText.Text);
            typeText.Text = "";
            displayText.Text = "Cut!";



        }
    }
}

