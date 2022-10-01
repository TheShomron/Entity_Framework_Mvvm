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
    /// Interaction logic for UnderStudents.xaml
    /// </summary>
    public partial class UnderStudents : UserControl
    {
        public UnderStudents()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DAL.ChosenStudent == null || Grade_Input.Text == "")
            {
                Grade_Input.Text="error";
            }
            else
            {
                DAL.Context.ChangeGrade( double.Parse(Grade_Input.Text));
            }

            

            

        }


    }
}
