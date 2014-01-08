using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Random_Number_Gen
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

   



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            title.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            button.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            shape.Visibility = Windows.UI.Xaml.Visibility.Visible;
        }

        private void shape_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var bounds = Window.Current.Bounds;

            double height = bounds.Height;
            double width = bounds.Width;

            int iheight = (Convert.ToInt32(height));
            int iwidth = (Convert.ToInt32(width));

            Random no = new Random();
            int x = no.Next(iheight, iwidth);
            int y = no.Next(iheight, iwidth);

            string swidth = iwidth.ToString();
            //   a.Text = swidth;

            string sheight = iheight.ToString();
            //    cc.Text = sheight;


            string sx = Convert.ToString(x);
            string sy = Convert.ToString(y);

            //  boundsx.Text = sx;
            //   boundsy.Text = sy;

            TranslateTransform posTransform = new TranslateTransform();
            posTransform.X = (height - x);
            posTransform.Y = (width - y);

            // pop.Play();

            shape.RenderTransform = posTransform;

        }

      

    }
}
