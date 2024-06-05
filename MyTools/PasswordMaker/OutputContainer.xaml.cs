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

        private async void OnCopyButtonClicked(object sender, EventArgs e)
        {
            string textToCopy = outputLabel.Text;
            var btn = sender as ImageButton;

            btn.Source = "Resources/AppIcon/check_mark.png";
            btn.IsEnabled = false;

            if (firstRadioButton.IsChecked)
            {
                if (int.TryParse(charCountEntry.Text, out int charCount))
                {
                    textToCopy = textToCopy.Substring(0, Math.Min(charCount, textToCopy.Length));
                }
            }
            else if (lastRadioButton.IsChecked)
            {
                if (int.TryParse(charCountEntry.Text, out int charCount))
                {
                    textToCopy = textToCopy.Substring(Math.Max(0, textToCopy.Length - charCount));
                }
            }

            await Clipboard.Default.SetTextAsync(textToCopy);
            await Task.Delay(2000);
            btn.Source = "Resources/AppIcon/copy.png";
            btn.IsEnabled = true;
        }
    }
}
