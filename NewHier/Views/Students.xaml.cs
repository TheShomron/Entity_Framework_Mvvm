using NewHier.Service;
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

namespace NewHier.Views
{
    /// <summary>
    /// Interaction logic for Students.xaml
    /// </summary>
    public partial class Students : UserControl
    {
        public Students()
        {
            InitializeComponent();
        }

        private void LVStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender.Equals(LVStudents) && LVStudents.SelectedItem is Student S)
            {
                DAL.Context.GetTeacherOfStudent(S);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
