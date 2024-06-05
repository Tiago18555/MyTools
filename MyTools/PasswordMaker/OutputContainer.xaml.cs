using Microsoft.Maui.Controls;

namespace MyTools
{
    public partial class OutputContainer : ContentView
    {
        public OutputContainer()
        {
            InitializeComponent();
        }

        public void SetOutput(string output)
        {
            outputLabel.Text = output;
        }
    }
}
