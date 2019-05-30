using System;
using System.ServiceModel;

namespace WcfService1
{
    [ServiceContract]
    public interface ITestService
    {
        [OperationContract]
        String GetMessage();
    }
    public class TestService : ITestService
    {
        public String GetMessage()
        {
            return "Hello World";
        }
    }
}
