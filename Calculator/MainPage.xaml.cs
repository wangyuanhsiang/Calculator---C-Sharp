using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class MainPage : Page
    {
        private double firstnum;
        private double firstnumSum; 
        private double secondnum;
        private double result;
        private String operation;
        private int i = 0;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            String localnum = TBTextbox.Text + Button1.Tag;
            TBTextbox.Text = localnum.ToString();
            
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            String localnum = TBTextbox.Text + Button2.Tag;
            TBTextbox.Text = localnum.ToString();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            String localnum = TBTextbox.Text + Button3.Tag;
            TBTextbox.Text = localnum.ToString();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            String localnum = TBTextbox.Text + Button4.Tag;
            TBTextbox.Text = localnum.ToString();
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            String localnum = TBTextbox.Text + Button5.Tag;
            TBTextbox.Text = localnum.ToString();
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            String localnum = TBTextbox.Text + Button6.Tag;
            TBTextbox.Text = localnum.ToString();
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            String localnum = TBTextbox.Text + Button7.Tag;
            TBTextbox.Text = localnum.ToString();
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            String localnum = TBTextbox.Text + Button8.Tag;
            TBTextbox.Text = localnum.ToString();
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            String localnum = TBTextbox.Text + Button9.Tag;
            TBTextbox.Text = localnum.ToString();
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            String localnum = TBTextbox.Text + Button0.Tag;
            TBTextbox.Text = localnum.ToString();
        }

        private void ButtonDoc_Click(object sender, RoutedEventArgs e)
        {
            String localnum = TBTextbox.Text + ButtonDoc.Tag;
            TBTextbox.Text = localnum.ToString();
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TBTextbox.Text = " ";
            firstnumSum = 0.0;
            result = 0.0;
            i = 0;
        }

        private void ButtonAddition_Click(object sender, RoutedEventArgs e)
        {
           
            firstnum = Double.Parse(TBTextbox.Text);
            //firstnumSum += firstnum;
            switch (operation)
            {
                case "+":
                    firstnumSum += firstnum;
                    //TBTextbox.Text = String.Format("{0:0.0}", result);
                    break;
                case "-":
                    firstnumSum = firstnumSum - firstnum;
                    //TBTextbox.Text = String.Format("{0:0.0}", result);
                    break;
                case "/":
                    result = firstnumSum / firstnum;
                    //TBTextbox.Text = String.Format("{0:0.0}", result);
                    break;
                case "*":
                    result = firstnumSum * firstnum;
                    //TBTextbox.Text = String.Format("{0:0.0}", result);
                    break;
                default:
                    //TBTextbox.Text = "";
                    firstnumSum += firstnum;
                    break;
            }
            operation = "+";
            TBTextbox.Text = " ";
            i++;
        }

        private void ButtonSubtraction_Click(object sender, RoutedEventArgs e)
        {
            firstnum = Double.Parse(TBTextbox.Text);
            //if(i == 0)
            //{
            //    firstnumSum = firstnum - firstnumSum;
            //}
            //if(i != 0)
            //{
            //    firstnumSum = firstnumSum - firstnum;
            //}
            switch (operation)
            {
                case "+":
                    firstnumSum += firstnum;
                    //TBTextbox.Text = String.Format("{0:0.0}", result);
                    break;
                case "-":
                    result = firstnumSum - firstnum;
                    //TBTextbox.Text = String.Format("{0:0.0}", result);
                    break;
                case "/":
                    result = firstnumSum / firstnum;
                    //TBTextbox.Text = String.Format("{0:0.0}", result);
                    break;
                case "*":
                    result = firstnumSum * firstnum;
                    //TBTextbox.Text = String.Format("{0:0.0}", result);
                    break;
                default:
                    //TBTextbox.Text = "";
                    if (i == 0)
                    {
                        firstnumSum = firstnum - firstnumSum;
                    }
                    if (i != 0)
                    {
                        firstnumSum = firstnumSum - firstnum;
                    }
                    break;
            }
            operation = "-";  
            TBTextbox.Text = " ";
            i++;
        }

        private void ButtonDivision_Click(object sender, RoutedEventArgs e)
        {
            firstnumSum = Double.Parse(TBTextbox.Text);
            operation = "/";
            TBTextbox.Text = " ";
        }

        private void ButtonMul_Click(object sender, RoutedEventArgs e)
        {
            firstnumSum = Double.Parse(TBTextbox.Text);
            operation = "*";
            TBTextbox.Text = " ";
        }

        private void ButtonAve_Click(object sender, RoutedEventArgs e)
        {
            double localnum = result / i;
            TBTextbox.Text = String.Format("{0:0.0}", localnum);
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            i++;
            secondnum = Double.Parse(TBTextbox.Text);
            switch (operation)
            {
                case "+":
                    result = firstnumSum + secondnum;
                    TBTextbox.Text = String.Format("{0:0.0}", result);
                    break;
                case "-":
                    result = firstnumSum - secondnum;
                    TBTextbox.Text = String.Format("{0:0.0}", result);
                    break;
                case "/":
                    result = firstnumSum / secondnum;
                    TBTextbox.Text = String.Format("{0:0.0}", result);
                    break;
                case "*":
                    result = firstnumSum * secondnum;
                    TBTextbox.Text = String.Format("{0:0.0}", result);
                    break;
                default:
                    TBTextbox.Text = "";
                    break;
             }

          } 

        }

       
    }
