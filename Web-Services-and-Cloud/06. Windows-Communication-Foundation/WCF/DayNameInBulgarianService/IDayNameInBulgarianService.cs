namespace DayNameInBulgarianService
{
    using System;
    using System.ServiceModel;

    [ServiceContract]
    public interface IDayNameInBulgarianService
    {
        [OperationContract]
        string GetDayOfWeekInBulgarian(DateTime dateTime);
    }
}