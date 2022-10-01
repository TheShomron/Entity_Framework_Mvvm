using NewHier.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHier.View_Models
{
    public class VM_Teachers
    {
        DAL data = DAL.Context;

        public ObservableCollection<Teacher> Teachers { get; set; }

        public VM_Teachers()
        {
            Teachers = new ObservableCollection<Teacher>(data.GetTeachers());

                
        }

 
        public void GetStudentsOfTeacher(Teacher T)
        {
            data.GetStudentsOfTeacher(T);
            DAL.ChosenTeacher = T;
        }

    
    }
}
