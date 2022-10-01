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
    /// Interaction logic for Teachers.xaml
    /// </summary>
    public partial class Teachers : UserControl
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void ListView_Selected(object sender, RoutedEventArgs e)
        {
            if(sender.Equals(LVTeacher) && LVTeacher.SelectedItem is Teacher T)
            {
                DAL.Context.GetStudentsOfTeacher(T);
            }
            
        }
    }
}
