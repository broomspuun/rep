using Library;
using System.Windows;


namespace ManagerStaffApp
{
    public partial class AddingUser : Window
    {
        public AddingUser()
        {
            InitializeComponent();
        }

        private void Button_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataManager.CreateUser(textBoxName.Text, textBoxSurName.Text, int.Parse(textBoxSalary.Text), textBoxPosition.Text);
            }
            catch(System.FormatException)
            {
                DataManager.CreateUser(textBoxName.Text, textBoxSurName.Text,0, textBoxPosition.Text);
            }
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }
    }
}
