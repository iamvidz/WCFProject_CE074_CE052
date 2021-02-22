using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Assignment
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool AddExam(Exam exam);

        [OperationContract]
        bool DeleteExam(int id);

        [OperationContract]
        Exam GetExam(int examid);

        [OperationContract]
        bool PostExam(int examid);

        [OperationContract]
        List<Exam> GetAllPostedExam(string teacher);
        [OperationContract]
        List<Exam> GetAllExam(string teacher);
    }

    
}
