using AggressivenessOfWaterAndGround.ViewModel;
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

namespace AggressivenessOfWaterAndGround
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }

        //Logic for better working of View

        //Checks that the user enters an integer in the textbox, so user can't even input incorrect char
        private void CheckInt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        //Checks that the user enters an double in the textbox, so user can't input incorrect char
        private void CheckDouble_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
            {
                //Checking that user inputed a only one "."
                if ((e.Text == ".") && !((TextBox)sender).Text.Contains(".") && ((TextBox)sender).Text.Length != 0)
                {
                    return;
                }

                e.Handled = true;
            }

        }

        //Checks so that user don't input "space" and transmits focus to next element by "Enter"
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Space:
                    e.Handled = true;
                    break;
                case Key.Enter:
                    TraversalRequest tRequest = new TraversalRequest(FocusNavigationDirection.Next);
                    UIElement keyboardFocus = Keyboard.FocusedElement as UIElement;
                    if (keyboardFocus != null)
                    {
                        keyboardFocus.MoveFocus(tRequest);
                    }
                    e.Handled = true;
                    break;
                default:
                    break;
            }
        }

        //Selects all text in textBox when it got focus
        private void SelectAllText_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
