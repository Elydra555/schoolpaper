using ConsoleApp2.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using static ConsoleApp2.Models.People;

namespace schoolPaper.View
{
    /// <summary>
    /// Interaction logic for DataView.xaml
    /// </summary>
    public partial class DataView : UserControl
    {
        private readonly Context _context;
        private User _selectedUser;

        public DataView()
        {
            InitializeComponent();
            _context = new Context();
            LoadData();
        }

        private void LoadData()
        {
            var users = _context.User.ToList();
            listBox.ItemsSource = users;
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                _selectedUser = (User)listBox.SelectedItem;
                nameTextBox.Text = _selectedUser.Name;
                ageTextBox.Text = _selectedUser.Age;
                cityTextBox.Text = _selectedUser.City;
                positionTextBox.Text = _selectedUser.Position;
                hobbyTextBox.Text = _selectedUser.Hobby;
            }
        }

        private async void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedUser != null)
            {
                _selectedUser.Name = nameTextBox.Text;
                _selectedUser.Age = ageTextBox.Text;
                _selectedUser.City = cityTextBox.Text;
                _selectedUser.Position = positionTextBox.Text;
                _selectedUser.Hobby = hobbyTextBox.Text;

                _context.User.Update(_selectedUser);
                await _context.SaveChangesAsync();
                LoadData();
            }
        }

        private async void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (_selectedUser != null)
            {
                _context.User.Remove(_selectedUser);
                await _context.SaveChangesAsync();
                LoadData();
                ClearFields();
            }
        }

        private void ClearFields()
        {
            nameTextBox.Text = "";
            ageTextBox.Text = "";
            cityTextBox.Text = "";
            positionTextBox.Text = "";
            hobbyTextBox.Text = "";
        }
    }
}

