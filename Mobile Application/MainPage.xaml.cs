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
using Windows.UI.Popups;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Module2
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            BL_PageContent.CreatedBy = "Created By: Josef Izquierdo";
            txtBoxFooter.Text = BL_PageContent.CreatedBy;

        }
        private void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        public void ChangeHeader()
        {
            txtBoxRas.Text = "Rasmussen College";
            txtBoxRas.FontSize = 14;
            txtBoxRas.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
        }
            private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            ProcessCalc();
        }

        private void ProcessCalc()
        {
            Int32 Var1 = Convert.ToInt32(txtBoxInput1.Text) + Convert.ToInt32(txtBoxInput2.Text);
            txtBoxDisplay.Text = Convert.ToString(Var1);
        }

        public static string VarOutput { get; set; } //place property within the class
        //string VarOutput;

        async private void btnCourse1_Click(object sender, RoutedEventArgs e)
        {
          
            string[] names = new string[3] { "COP3488C", "UWP1", "This course is mobile app development." };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "  ";
            }
            txtBoxCourse.Text = VarOutput;
            var dialog = new MessageDialog(VarOutput);
            await dialog.ShowAsync();

        }

        async private void btnCourse2_Click(object sender, RoutedEventArgs e)
        {
            string[] names = new string[3] { "CIS3801C", "Fundamentals of Mobile Web Application Development", "Creating Web Apps." };

            for (int i = 0; i < names.Length; i++)
            {
                VarOutput = VarOutput + names[i] + "  ";
            }
            txtBoxCourse.Text = VarOutput;
            var dialog = new MessageDialog(VarOutput);
            await dialog.ShowAsync();
        }

        async private void btnCourse3_Click(object sender, RoutedEventArgs e)
        {
            BL_PageContent.Course1();
            txtBoxCourse.Text = BL_PageContent.VarOutput;
            var dialog = new MessageDialog(BL_PageContent.VarOutput);
            await dialog.ShowAsync();

        }

        private void hypLnkPage2_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Faculty));
        }

        private void hypLnkPage3_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UserAuth));
        }
    }

}
