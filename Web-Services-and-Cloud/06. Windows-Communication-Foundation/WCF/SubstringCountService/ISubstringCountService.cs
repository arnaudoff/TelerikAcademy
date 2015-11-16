namespace SubstringCountService
{
    using System.ServiceModel;

    [ServiceContract]
    public interface ISubstringCountService
    {
        /// <summary>
        /// Accepts two strings as parameters.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns>The number of times the second string contains the first string.</returns>
        [OperationContract]
        int GetOccurencesCount(string first, string second);
    }
}