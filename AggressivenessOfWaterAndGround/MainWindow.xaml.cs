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
        }



        private void AmountOfSO4orHCO3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox && ((TextBox)sender).Name == "AmountOfSO4")
            {
                WaterData.AggressivenessData.AmountSO4 = ((TextBox)sender).Text != "" ? uint.Parse(((TextBox)sender).Text) : 0;
            }
            if (sender is TextBox && ((TextBox)sender).Name == "AmountOfHCO3")
            {
                WaterData.AggressivenessData.AmountHCO3 = ((TextBox)sender).Text != "" ? double.Parse(((TextBox)sender).Text) : 0;
            }

            TextBlock[] ElementOfView = GetAllElementsDisplayingAgr();
            Border[] BorderOfElementOfView = GetAllBorderOfElementsDisplayingAgr();
            string[] DataForView = WaterData.AggressivenessData.GetAllCement();

            //Sets value to element textblock and changes background color
            for (int i = 0; i < ElementOfView.Length; i++)
            {
                ElementOfView[i].Text = DataForView[i];

                if (DataForView[i] == "Введите значение HCO3")
                    BorderOfElementOfView[i].Background = new SolidColorBrush(Color.FromRgb(200, 200, 200));

                else if (DataForView[i] == "Неагрессивная")
                    BorderOfElementOfView[i].Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));

                else if (DataForView[i] == "Слабоагрессивная")
                    BorderOfElementOfView[i].Background = new SolidColorBrush(Color.FromRgb(98, 179, 149));
                
                else if (DataForView[i] == "Среднеагрессивная")
                    BorderOfElementOfView[i].Background = new SolidColorBrush(Color.FromRgb(229, 240, 105));
                
                else if (DataForView[i] == "Сильноагрессивная")
                    BorderOfElementOfView[i].Background = new SolidColorBrush(Color.FromRgb(214, 84, 45));
            }
        }

        //Сhecks that a number is entered into the textbox
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
            {
                //AmountOfHCO3 can contaned a type double, so there is checking that user inputed a only one ","
                if (sender is TextBox && ((TextBox)sender).Name == "AmountOfHCO3" &&
                    (e.Text == ",") && !((TextBox)sender).Text.Contains(",") &&
                    ((TextBox)sender).Text.Length != 0)
                {
                    return;
                }
                
                e.Handled = true;
            }

        }

        //Checks so that user didn't input "space" and transmits focus to next element by "Enter"
        private void TextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }

            if (e.Key == Key.Enter)
            {
                TraversalRequest tRequest = new TraversalRequest(FocusNavigationDirection.Next);
                UIElement keyboardFocus = Keyboard.FocusedElement as UIElement;

                if (keyboardFocus != null)
                {
                    keyboardFocus.MoveFocus(tRequest);
                }

                e.Handled = true;
            }
        }

        //Returns set, which contains elements of view, which are displaying the power of aggressiveness
        private TextBlock[] GetAllElementsDisplayingAgr()
        {
            TextBlock[] elements = {
                                    IW4, IW6, IW8, IW10_W14, IW16_W20,
                                    IIW4, IIW6, IIW8, IIW10_W14, IIW16_W20,
                                    IIIW4, IIIW6, IIIW8, IIIW10_W14, IIIW16_W20,
                                   };
            return elements;

        }

        //Returns set, which contains borders of elements of view, which are displaying the power of aggressiveness
        private Border[] GetAllBorderOfElementsDisplayingAgr()
        {
            Border[] borderElements = {
                                       Border_IW4, Border_IW6, Border_IW8, Border_IW10_W14, Border_IW16_W20,
                                       Border_IIW4, Border_IIW6, Border_IIW8, Border_IIW10_W14, Border_IIW16_W20,
                                       Border_IIIW4, Border_IIIW6, Border_IIIW8, Border_IIIW10_W14, Border_IIIW16_W20,
                                      };
            return borderElements;
        }

        //Selects all text in textBox when it got focus
        private void AmountOfSO4_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).SelectAll();
            }
        }
    }
}
