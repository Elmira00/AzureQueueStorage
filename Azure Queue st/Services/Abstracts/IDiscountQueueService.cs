namespace AzureQueueSt.Services.Abstracts
{
    public interface IDiscountQueueService
    {
        Task SendMessageAsync(string message);
        Task<string> ReceiveMessageAsync();
    }
}
