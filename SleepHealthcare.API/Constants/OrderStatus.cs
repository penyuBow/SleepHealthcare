namespace SleepHealthcare.API.Constants
{
    public enum OrderStatus
    {
        New,
        InsuranceVerified,
        PriorAuthRequired,
        PriorAuthObtained,
        Scheduled,
        InProgress,
        Completed,
        Cancelled
    }
}
