using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_NumberGuessing
{

    public class Service1 : IService1
    {

        //Operation to generate a Secrete Number within lower and upper limits defined by the user
        public int SecretNumber(int lower, int upper)
        {
            DateTime currentDate = DateTime.Now;
            int seed = (int)currentDate.Ticks;
            Random random = new Random(seed);
            int sNumber = random.Next(lower, upper);
            return sNumber;

        }

        //Operation to define if the entered guess number is correct, bigger or smaller compared to the generated secrete number
        public string checkNumber(int userNum, int SecretNum)
        {
            if (userNum == SecretNum)
                return "correct";
            else
                if (userNum > SecretNum)
                 return "too big";
                else return "too small";
        }

    }
}
