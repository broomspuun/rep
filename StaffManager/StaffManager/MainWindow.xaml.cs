using Library;
using System.Windows;

namespace ManagerStaffApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            DataStore dm = new DataStore();
            lbUsers.ItemsSource = dm.AllUsers;
            lbPositions.ItemsSource = dm.AllPositions;
        }

        private void Button_Add_User_Click(object sender, RoutedEventArgs e)
        {
            AddingUser AddingUserdWindow = new AddingUser();
            AddingUserdWindow.Show();
            Hide();
        }

    }
}
