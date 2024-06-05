using Microsoft.Maui.Controls;

namespace MyTools
{
    public partial class InputContainer : ContentView
    {
        public event EventHandler PlayButtonClicked;
        public InputContainer()
        {
            InitializeComponent();
            hashTypePicker.SelectedIndex = 0;
        }

        public string GetInputText()
        {
            return inputEntry.Text;
        }

        public string GetSelectedHashType()
        {
            return hashTypePicker.SelectedItem?.ToString();
        }

        private void OnPlayButtonClicked(object sender, EventArgs e)
        {
            PlayButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void OnToggleListClicked(object sender, EventArgs e)
        {
            // Placeholder for toggling the visibility of the list (not implemented)
        }
    }
}
