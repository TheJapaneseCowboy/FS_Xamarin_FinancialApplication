using System;

using Xamarin.Forms;

namespace FS_Xamarin_Financial_Application
{
    public class DashBoardPage : ContentPage
    {
        public DashBoardPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

