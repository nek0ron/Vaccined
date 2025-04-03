namespace Vaccined
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Hide();
            Auth auth = new Auth();
            auth.ShowDialog();
        }
    }
}
