using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MSService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentService" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/getStudentList"
       )]
        List<Student> getStudents();
        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/createStudent"
      )]
        bool createStudent(Student newStudent);
        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/editStudent/{id}"
      )]
        bool editStudent(string id, Student newStudent);
        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/deleteStudent/{id}"

      )]
        bool deleteStudent(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
          ResponseFormat = WebMessageFormat.Json,
          RequestFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.Bare,
          UriTemplate = "api/v1/getClassList"
     )]
        List<Class> getClasses();
        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/createClass"
      )]
        bool createClass(Class newClass);
        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/editClass/{id}"
      )]
        bool editClass(string id, Class newClass);
        [OperationContract]
        [WebInvoke(Method = "POST",
           ResponseFormat = WebMessageFormat.Json,
           RequestFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare,
           UriTemplate = "api/v1/deleteClass/{id}"
      )]
        bool deleteClass(string id);
    }
}
