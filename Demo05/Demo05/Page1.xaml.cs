using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo05
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            StackLayout stack = new StackLayout();
            Label label = new Label();

            label.Text = "Nuevo label";
            label.BackgroundColor = Color.Green;
            stack.Children.Add(label);


            for (int i = 0; i < 5; i++)
            {
                Button button = new Button();
                button.Text = "Nuevo botón";
                button.BackgroundColor = Color.Red;
                stack.Children.Add(button);

            }

            this.Content = stack;
        }
    }
}