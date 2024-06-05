using Microsoft.Maui.Controls;
using System;
using System.Security.Cryptography;
using System.Text;

namespace MyTools
{
    public partial class PasswordMakerPage : ContentPage
    {
        public PasswordMakerPage()
        {
            InitializeComponent();
            InputContainer.PlayButtonClicked += OnPlayButtonClicked;
        }

        public void OnPlayButtonClicked(object sender, EventArgs e)
        {
            var inputText = ((InputContainer)this.FindByName("InputContainer")).GetInputText();
            var hashType = ((InputContainer)this.FindByName("InputContainer")).GetSelectedHashType();

            var result = Encrypt(inputText, hashType);

            ((OutputContainer)this.FindByName("OutputContainer")).SetOutput(result);
        }

        private string Encrypt(string input, string hashType)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            switch (hashType.ToUpper())
            {
                case "BASE64":
                    return Convert.ToBase64String(inputBytes);
                case "HEX":
                    return BitConverter.ToString(inputBytes).Replace("-", "").ToLower();
                case "SHA1":
                    using (SHA1 sha1 = SHA1.Create())
                    {
                        byte[] hashBytes = sha1.ComputeHash(inputBytes);
                        return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                    }
                case "SHA256":
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] hashBytes = sha256.ComputeHash(inputBytes);
                        return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                    }
                case "SHA384":
                    using (SHA384 sha384 = SHA384.Create())
                    {
                        byte[] hashBytes = sha384.ComputeHash(inputBytes);
                        return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                    }
                case "SHA512":
                    using (SHA512 sha512 = SHA512.Create())
                    {
                        byte[] hashBytes = sha512.ComputeHash(inputBytes);
                        return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                    }
                default:
                    throw new ArgumentException("Invalid hash type");
            }
        }
    }
}
