using Microsoft.Maui.Controls;

namespace MyTools
{
    public partial class PasswordMakerPage : ContentPage
    {
        //#2C2C54
        //#474787
        //#AAABB8
        //#ECECEC
        public PasswordMakerPage()
        {
            InitializeComponent();
        }

        public void OnPlayButtonClicked()
        {
            // Handle Play button clicked in InputContainer
            var inputText = ((InputContainer)this.FindByName("InputContainer")).GetInputText();
            var hashType = ((InputContainer)this.FindByName("InputContainer")).GetSelectedHashType();

            // Process the input text with the selected hash type
            var result = Encrypt(inputText, hashType);

            // Set the result in the OutputContainer
            ((OutputContainer)this.FindByName("OutputContainer")).SetOutput(result);
        }

        private string Encrypt(string input, string hashType)
        {
            // Placeholder for real encryption logic based on hash type
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
