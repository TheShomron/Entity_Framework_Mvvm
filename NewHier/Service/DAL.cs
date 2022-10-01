using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHier.Service
{
    public class DAL
    {
        private readonly Model1Container _data;

        private static readonly DAL DataService = new DAL();
        private DAL()
        {
            _data = new Model1Container();

        }

        public static DAL Context
        {
            get
            {
                if (DataService == null)
                {
                    return new DAL();
                }
                else return DataService;
            }
        }

        public static Student ChosenStudent;
        public static Teacher ChosenTeacher;

        public Action<Teacher> GetStudentsOfTeacherEvent;
        public Action<Student> GetTeacherOfStudentEvent;
        public Action AddCourseEvent;


        
        
        public void GetTeacherOfStudent(Student S) { GetTeacherOfStudentEvent?.Invoke(S); ChosenStudent = S; }
        public void GetStudentsOfTeacher(Teacher T) { GetStudentsOfTeacherEvent?.Invoke(T); ChosenTeacher=T; }
        public void AddCourse() => AddCourseEvent?.Invoke();
        
        public List<Person> GetPersons()
        {
           return _data.Persons.ToList();
        }
        public List<Teacher> GetTeachers()
        {
            return _data.Persons.OfType<Teacher>().ToList();
        }
        public List<Student> GetStudents()
        {
           return _data.Persons.OfType<Student>().ToList();
        }

        public IEnumerable<CourseTypes> GetCourses()
        {
            return Enum.GetValues(typeof(CourseTypes)).Cast<CourseTypes>();
        }

        public bool ChangeGrade( Double Grade)
        {
            if(ChosenStudent != null)
            {
               
                ChosenStudent.Grade = Grade;
                _data.SaveChanges();
                return true;
            }
            return false;


          
            

        }

        //public void AddCourse(CourseTypes Course)
        //{
        //    if (ChosenTeacher.Courses.HasFlag(Course))
        //    {
        //        ChosenTeacher.Courses |= Course;
        //        DAL.Context.SaveChange();
        //    }
        //}

        public void SaveChange()
        {
            _data.SaveChanges();
        }

     
    }
}
