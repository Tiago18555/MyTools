namespace MyTools
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(PasswordMakerPage), typeof(PasswordMakerPage));
        }
    }
}
