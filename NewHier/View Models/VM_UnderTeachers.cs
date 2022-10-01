using GalaSoft.MvvmLight.Command;
using NewHier.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHier.View_Models
{
    public class VM_UnderTeachers
    {
        DAL data = DAL.Context;

      
        public ObservableCollection<Student> Students { get; set; }
        public ObservableCollection<CourseTypes> Courses { get; set; }
        public CourseTypes SelectedCourse { get; set; }

        public RelayCommand AddCourseCommand { get; set; }

        public VM_UnderTeachers()
        {
            Courses = new ObservableCollection<CourseTypes>(DAL.Context.GetCourses());



            DAL.Context.GetStudentsOfTeacherEvent+=GetStudentsOfTeacher;
            DAL.Context.AddCourseEvent+=AddCourse;

            Students = new ObservableCollection<Student>();

            AddCourseCommand = new RelayCommand(AddCourse);
        }
        public void GetStudentsOfTeacher(Teacher T)
        {
            Students.Clear();
            foreach (Student s in T.Student)
            {
                Students.Add(s);
            }
            DAL.ChosenTeacher = T;
        }

        public void AddCourse()
        {
            if (!DAL.ChosenTeacher.Courses.HasFlag(SelectedCourse))
            {
                DAL.ChosenTeacher.Courses |= SelectedCourse;
                data.SaveChange();
            }
        }


    }
}
