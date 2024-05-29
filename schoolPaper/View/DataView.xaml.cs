using ConsoleApp2.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static ConsoleApp2.Models.People;

namespace schoolPaper.View
{
    /// <summary>
    /// Interaction logic for DataView.xaml
    /// </summary>
    public partial class DataView : UserControl
    {
        private Context _context;

        public DataView()
        {
            InitializeComponent();
            _context = new Context();
            _context.ConnectionString = @"Server=(localdb)\MsSqlLocalDb;Database=Benedek;Trusted_Connection=true";
            //LoadData();
        }

        //private void LoadData()
        //{
        //    List<User> people = _context.User.ToList();
        //    foreach (var person in people)
        //    {
        //        listBox.Items.Add(person.FirstName);
        //    }
        //}

        //private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (listBox.SelectedIndex != -1)
        //    {
        //        string selectedFirstName = (string)listBox.SelectedItem;
        //        User selectedPerson = _context.User.FirstOrDefault(p => p.FirstName == selectedFirstName);
        //        if (selectedPerson != null)
        //        {
        //            textBox.Text = $"Name: {selectedPerson.FirstName} {selectedPerson.LastName}\nEmail: {selectedPerson.Email}";
        //        }
        //    }
        //}

        //private void UpdateButton_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    if (listBox.SelectedIndex != -1)
        //    {
        //        string selectedFirstName = (string)listBox.SelectedItem;
        //        User selectedPerson = _context.User.FirstOrDefault(p => p.FirstName == selectedFirstName);
        //        if (selectedPerson != null)
        //        {
        //            // Itt kezeld az Update műveletet
        //            MessageBox.Show("Update művelet végrehajtva!");
        //        }
        //    }
        //}

        //private void DeleteButton_Click(object sender, System.Windows.RoutedEventArgs e)
        //{
        //    if (listBox.SelectedIndex != -1)
        //    {
        //        string selectedFirstName = (string)listBox.SelectedItem;
        //        Person selectedPerson = _context.People.FirstOrDefault(p => p.FirstName == selectedFirstName);
        //        if (selectedPerson != null)
        //        {
        //            // Itt kezeld a Delete műveletet
        //            MessageBox.Show("Delete művelet végrehajtva!");
        //            _context.People.Remove(selectedPerson);
        //            _context.SaveChanges();
        //            listBox.Items.Remove(selectedFirstName);
        //            textBox.Clear();
        //        }
        //    }
        //}
    }
}

