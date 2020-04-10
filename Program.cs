using System.ServiceModel;

namespace ConsoleApp1
{
    [ServiceKnownType(typeof(Operation1Response))]
    [ServiceKnownType(typeof(Operation2Response))]
    [ServiceContract]
    public interface IExtraRedemptionService
    {
        [OperationContract]
        OperationResult<int> Operation1(string par);

        [OperationContract]
        OperationResult<MyClass> Operation2(long par);
    }
}
