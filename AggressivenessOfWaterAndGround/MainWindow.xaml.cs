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


        //performs minor adjustments that didn't work out with XAML
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CoefFiltratMoreThan01.IsChecked = true;
        }

        private void WaterAmountOfSO4orHCO3_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Depending on the sender (text block of SO4 or HCO3) it changes value variable amountSO4 or amountHCO3
            if (sender is TextBox && ((TextBox)sender).Name == "Water_AmountOfSO4")
            {
                WaterData.AggressivenessDataOfSO4.AmountSO4 = ((TextBox)sender).Text != "" ? uint.Parse(((TextBox)sender).Text) : 0;
            }
            if (sender is TextBox && ((TextBox)sender).Name == "Water_AmountOfHCO3")
            {
                WaterData.AggressivenessDataOfSO4.AmountHCO3 = ((TextBox)sender).Text != "" ? double.Parse(((TextBox)sender).Text) : 0;
            }

            TextBlock[] ElementOfView = GetAllElementsWhichDisplayingAgr("SO4");
            Border[] BorderOfElementOfView = GetAllBorderOfElementsWhichDisplayingAgr("SO4");
            string[] DataForView = WaterData.AggressivenessDataOfSO4.GetAllCement();

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

        private void WaterAmountOfCl_TextChanged(object sender, TextChangedEventArgs e)
        {
            WaterData.AggressivenessDataOfCl.AmountCL = ((TextBox)sender).Text != "" ? uint.Parse(((TextBox)sender).Text) : 0;
            TextBlock[] ElementOfView = GetAllElementsWhichDisplayingAgr("Cl");
            Border[] BorderOfElementOfView = GetAllBorderOfElementsWhichDisplayingAgr("Cl");
            string[] DataForView = WaterData.AggressivenessDataOfCl.GetAllCement();

            //Sets value to element textblock and changes background color
            for (int i = 0; i < ElementOfView.Length; i++)
            {
                ElementOfView[i].Text = DataForView[i];

                if (DataForView[i] == "Неагрессивная")
                    BorderOfElementOfView[i].Background = new SolidColorBrush(Color.FromRgb(255, 255, 255));

                else if (DataForView[i] == "Агрессивная")
                    BorderOfElementOfView[i].Background = new SolidColorBrush(Color.FromRgb(214, 84, 45));
            }
        }

        //Сhecks that a number is entered into the textbox
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0))
            {
                //AmountOfHCO3 can contaned a type double, so there is checking that user inputed a only one ","
                if (sender is TextBox && ((TextBox)sender).Name == "Water_AmountOfHCO3" &&
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

        /// <summary>
        /// Returns set, which contains elements of view, which are displaying the power aggressiveness of SO4
        /// </summary>
        /// <param name="whichElementsToReturn">
        /// Enter element of view: SO4 or Сl
        /// </param>
        private TextBlock[] GetAllElementsWhichDisplayingAgr(string whichElementsToReturn)
        {
            if (whichElementsToReturn == "SO4")
            {
                TextBlock[] elements = {
                                        WaterSO4_IW4, WaterSO4_IW6, WaterSO4_IW8, WaterSO4_IW10_W14, WaterSO4_IW16_W20,
                                        WaterSO4_IIW4, WaterSO4_IIW6, WaterSO4_IIW8, WaterSO4_IIW10_W14, WaterSO4_IIW16_W20,
                                        WaterSO4_IIIW4, WaterSO4_IIIW6, WaterSO4_IIIW8, WaterSO4_IIIW10_W14, WaterSO4_IIIW16_W20,
                                       };
                return elements;
            }
            else if (whichElementsToReturn == "Cl")
            {
                TextBlock[] elements = {
                                        WaterCL_20_W6_W8, WaterCL_20_W10_W14, WaterCL_20_W16_W20,
                                        WaterCL_30_W6_W8, WaterCL_30_W10_W14, WaterCL_30_W16_W20,
                                        WaterCL_50_W6_W8, WaterCL_50_W10_W14, WaterCL_50_W16_W20
                                       };
                return elements;
            }
            else
                return new TextBlock[0];
        }

        /// <summary>
        /// Returns set, which contains borders of elements of view, which are displaying the power aggressiveness of SO4
        /// </summary>
        /// <param name="whichElementBordersToReturn">
        /// Enter element of view: SO4 or Сl
        /// </param>
        private Border[] GetAllBorderOfElementsWhichDisplayingAgr(string whichElementBordersToReturn)
        {
            if (whichElementBordersToReturn == "SO4")
            {
                Border[] borderElements = {
                                           WaterSO4_Border_IW4, WaterSO4_Border_IW6, WaterSO4_Border_IW8, WaterSO4_Border_IW10_W14, WaterSO4_Border_IW16_W20,
                                           WaterSO4_Border_IIW4, WaterSO4_Border_IIW6, WaterSO4_Border_IIW8, WaterSO4_Border_IIW10_W14, WaterSO4_Border_IIW16_W20,
                                           WaterSO4_Border_IIIW4, WaterSO4_Border_IIIW6, WaterSO4_Border_IIIW8, WaterSO4_Border_IIIW10_W14, WaterSO4_Border_IIIW16_W20,
                                          };
                return borderElements;
            }
            else if (whichElementBordersToReturn == "Cl")
            {
                Border[] borderElements = {
                                           WaterCL_Border_20_W6_W8, WaterCL_Border_20_W10_W14, WaterCL_Border_20_W16_W20,
                                           WaterCL_Border_30_W6_W8, WaterCL_Border_30_W10_W14, WaterCL_Border_30_W16_W20,
                                           WaterCL_Border_50_W6_W8, WaterCL_Border_50_W10_W14, WaterCL_Border_50_W16_W20
                                          };
                return borderElements;
            }
            else
                return new Border[0];
        }

        //Selects all text in textBox when it got focus
        private void SelectAllWhen_GotFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void IsChecked_Strikethrough_Clear(object sender, RoutedEventArgs e)
        {
            if (((RadioButton)sender).Name == "CoefFiltratMoreThan01")
            {
                TextCoefFiltratMoreThan01.TextDecorations = null;
                WaterData.AggressivenessDataOfCl.CoefFiltratMoreThan01 = true;
            }
            if (((RadioButton)sender).Name == "CoefFiltratLessThan01")
            {
                TextCoefFiltratLessThan01.TextDecorations = null;
            }
        }

        private void UnChecked_СrossOut_Text(object sender, RoutedEventArgs e)
        {
            if (((RadioButton)sender).Name == "CoefFiltratMoreThan01")
            {
                TextCoefFiltratMoreThan01.TextDecorations = TextDecorations.Strikethrough;
                WaterData.AggressivenessDataOfCl.CoefFiltratMoreThan01 = false;
            }
            if (((RadioButton)sender).Name == "CoefFiltratLessThan01")
            {
                TextCoefFiltratLessThan01.TextDecorations = TextDecorations.Strikethrough;
            }
        }


    }
}
