using BrokFindTeacher.Models;
using BrokFindTeacher.UserControls;
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
using System.Windows.Shapes;

namespace BrokFindTeacher.Windows
{
    /// <summary>
    /// Interaction logic for wBrok.xaml
    /// </summary>
    public partial class wBrok : Window
    {
        public wBrok()
        {
            InitializeComponent();
        }

        private void wMain_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void StackPanel_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var item in new Repository.RepositoryPerson().People)
            {
                var personControl = new UserControls.usPeople();
                personControl.DataContext = item;
                personControl.Tag = item.Name;
                personControl.MouseLeftButtonDown += PersonControl_MouseLeftButtonDown;
                spPeople.Children.Add(personControl);
            }
        }

        private void PersonControl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            usInfo.DataContext = new Repository.RepositoryPerson().People.FirstOrDefault(s => s.Name == (sender as usPeople).Tag);

        }
    }
}
