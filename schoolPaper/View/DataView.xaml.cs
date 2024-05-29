using ConsoleApp1.Data;
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
using static ConsoleApp1.Models.People;

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
            LoadData();
        }

        private void LoadData()
        {
            List<User> people = _context.User.ToList();
            foreach (var person in people)
            {
                listBox.Items.Add($"{person.Name} {person.Age} {person.City} {person.Position} {person.Hobby}");
            }
        }
    }
}
