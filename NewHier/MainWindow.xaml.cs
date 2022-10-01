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

namespace NewHier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            /*using (var data = new Model1Container())
           {
       

          IEnumerable<Person> teachers = data.Persons.OfType<Teacher>().ToList();
          IEnumerable<Person> Students = data.Persons.OfType<Student>().ToList();

          data.SaveChanges;

                
          }*/
            /*
             void INIT()
            {


                DAL.Context.GetPersons().Add(new Student { Name = "Elad", Grade=99 });
                DAL.Context.GetPersons().Add(new Student { Name = "Oral", Grade=80 });
                DAL.Context.GetPersons().Add(new Student { Name = "Itay", Grade=85 });
                data.Persons.Add(new Teacher { Name="Demitri", Course = CourseType.WPF });

                DAL.Context.GetPersons().Add(new Teacher { Name="Roi", Course = CourseType.WPF | CourseType.Java });
                DAL.Context.GetPersons().Add(new Teacher { Name="Shira", Course = CourseType.Azure });
                DAL.Context.GetPersons().Add(new Teacher { Name="Alon", Course = CourseType.C });
                DAL.Context.GetTeachers().Add(new Teacher { Name="Demitri", Course = CourseType.WPF });

                var T = DAL.Context.GetTeachers();
                var S = DAL.Context.GetStudents();

                T[0].Student.Add(S[1]);
                T[0].Student.Add(S[2]);

                T[1].Student.Add(S[0]);
                T[1].Student.Add(S[1]);
                T[1].Student.Add(S[2]);

                T[2].Student.Add(S[2]);

                S[0].Teacher.Add(T[0]);
                S[0].Teacher.Add(T[1]);
                S[0].Teacher.Add(T[2]);

                S[1].Teacher.Add(T[0]);

                S[2].Teacher.Add(T[2]);
                S[2].Teacher.Add(T[1]);

            DAL.Context.GetPersons().Add(new Teacher { Name="Demitri", Course = CourseType.WPF });
            DAL.Context.SaveChange();
                DAL.Context.SaveChange();
            }
            */

            using (var data = new Model1Container())
            {
                //data.Persons.Add(new Teacher { Name="Roi", Courses = CourseTypes.Wpf | CourseTypes.Java });
                //data.Persons.Add(new Teacher { Name="Shira", Courses = CourseTypes.Azure });
                //data.Persons.Add(new Teacher { Name="Matan", Courses = CourseTypes.CSharp });
                //data.Persons.Add(new Teacher { Name="Demitri", Courses = CourseTypes.Sql });

                //data.Persons.Add(new Student { Name = "Elad", Grade=22 });
                //data.Persons.Add(new Student { Name = "Amit", Grade=98 });
                //data.Persons.Add(new Student { Name = "Mika", Grade=67 });
                //data.Persons.Add(new Student { Name = "Sia", Grade=89 });

                var T = data.Persons.OfType<Teacher>().ToList();
                var S = data.Persons.OfType<Student>().ToList();

                //T[0].Student.Add(S[1]);
                //T[0].Student.Add(S[2]);
                //T[1].Student.Add(S[0]);
                //T[1].Student.Add(S[1]);
                //T[1].Student.Add(S[2]);
                //T[2].Student.Add(S[2]);
                //T[3].Student.Add(S[0]);
                //T[3].Student.Add(S[1]);
                //T[3].Student.Add(S[2]);
                //T[3].Student.Add(S[3]);

                //S[0].Teacher.Remove(T[0]);
                //S[0].Teacher.Remove(T[1]);
                //S[0].Teacher.Remove(T[2]);
                //S[1].Teacher.Remove(T[0]);
                //    S[2].Teacher.Add(T[2]);
                //    //S[2].Teacher.Remove(T[1]);
                //    //S[3].Teacher.Remove(T[3]);
                //    //S[3].Teacher.Remove(T[0]);

                //T[0].Student.Add(S[3]);
                //data.SaveChanges();
            }



        }
    }
}
