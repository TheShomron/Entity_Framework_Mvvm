using NewHier.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHier.View_Models
{
    public class VM_UnderStudents
    {
        DAL data = DAL.Context;
        public ObservableCollection<Teacher> Teachers { get; set; }

        public VM_UnderStudents()
        {
            Teachers = new ObservableCollection<Teacher>();

            DAL.Context.GetTeacherOfStudentEvent+=GetTeacherOfStudent;

           

        }



        public void GetTeacherOfStudent(Student S)
        {
            Teachers.Clear();
            foreach (Teacher T in S.Teacher)
            {
                Teachers.Add(T);
            }
            DAL.ChosenStudent = S;
        }



    }
}
