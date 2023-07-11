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

namespace Steven_Townsend_Programing_Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (this.Change.Content.ToString() == "Enter")
            {
                this.Change.Content = "Exit";
                this.ChangeText.Text = "ImagineSoftware is a leading provider of medical billing, revnue cycle, and practice management software";
            } else
            {
                this.Change.Content = "Enter";
                this.ChangeText.Text = "Hit the Enter Key";
            }
        }

        private void ChangeText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
