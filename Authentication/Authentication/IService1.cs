using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Portal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool addUser(String email, String fname, String lname, String password, String role);

        [OperationContract]

        User getSingleUser(String email);

        [OperationContract]

        bool update(String email, String fname, String lname, String role);

        [OperationContract]
        List<User> getUsers();

        [OperationContract]
        bool checkUser(String email, String password);

        [OperationContract]
        bool delete(String email, String password);

        // TODO: Add your service operations here
    }

    
}
