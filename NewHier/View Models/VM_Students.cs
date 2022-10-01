using NewHier.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHier.View_Models
{
    public class VM_Students
    {
         Student ChosenStudent = new Student();
        public static ObservableCollection<Student> Students { get; set; }
        
        DAL data = DAL.Context;
        public  VM_Students()
        {

            ShowStudents();
           
            

           
        }
     
        public void GetTeacherOfStudent(Student S)
        {
            ChosenStudent = S;
            data.GetTeacherOfStudent(S);
        }
        public static void ShowStudents()
        {
            Students = new ObservableCollection<Student>(DAL.Context.GetStudents());
           
        }

      
    }
}
