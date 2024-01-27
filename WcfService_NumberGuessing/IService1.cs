using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_NumberGuessing
{//Assignment 1 CSE446/598-Spring 2023: Advanced Services
    //Number Guessing Services
   // WCF SOAP service with 2 operations on localhost of Net IIS Express server
    [ServiceContract]
    public interface IService1
    { 
        //Operation to generate a Secrete Number within lower and upper limits defined by the user
        [OperationContract]
        int SecretNumber(int lower, int upper);

        //Operation to define if the entered guess number is correct, bigger or smaller compared to the generated secrete number
        [OperationContract]
        string checkNumber(int userNum, int SecretNum);
    }

}
