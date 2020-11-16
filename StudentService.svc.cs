using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentService.svc or StudentService.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService
    {
        MSStudentDataContext data = new MSStudentDataContext();

        public bool createClass(Class newClass)
        {
            try
            {
                data.Classes.InsertOnSubmit(newClass);
                data.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool createStudent(Student newStudent)
        {
            try
            {
                data.Students.InsertOnSubmit(newStudent);
                data.SubmitChanges();    
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool deleteClass(string id)
        {
            try
            {
                var classes = data.Classes.Where(c => c.ID == int.Parse(id)).FirstOrDefault();
                data.Classes.DeleteOnSubmit(classes);
                data.SubmitChanges();

                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool deleteStudent(string id)
        {
            try
            {
                var student = data.Students.Where(c => c.ID == int.Parse(id)).FirstOrDefault();
                data.Students.DeleteOnSubmit(student);
                data.SubmitChanges();
      
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool editClass(string id, Class newClass)
        {
            try
            {
                var class1 = data.Classes.Where(c => c.ID == int.Parse(id)).FirstOrDefault();
                data.Classes.DeleteOnSubmit(class1);
                data.Classes.InsertOnSubmit(newClass);
                data.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool editStudent(string id, Student newStudent)
        {
            try
            {
                var student = data.Students.Where(c => c.ID == int.Parse(id)).FirstOrDefault();
                data.Students.DeleteOnSubmit(student);
                data.Students.InsertOnSubmit(newStudent);
                data.SubmitChanges();
                return true;

            }
            catch
            {
                return false;
            }
           
        }

        public List<Class> getClasses()
        {

            try
            {
                var class1 = (from Class in data.Classes select Class).ToList();

                return class1;
            }
            catch
            {
                return null;
            }
        }

        public List<Student> getStudents()
        {
            try
            {
                var students = (from Student in data.Students select Student).ToList();

                return students;
            }
            catch
            {
                return null;
            }
        }
    }
}
