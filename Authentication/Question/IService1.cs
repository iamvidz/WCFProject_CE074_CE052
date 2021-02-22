using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Question
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        List<Que> GetAllQuestions();

        [OperationContract]
        Que FindQuestion(string question);

        [OperationContract]
        bool AddQuestion(Que question);

        [OperationContract]
        bool UpdateQuestion(string question, Que updatedVal);

        [OperationContract]
        bool DeleteQuestion(string question);

        [OperationContract]
        bool IsCorrect(string question, string answer);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Question.ContractType".
    
}
