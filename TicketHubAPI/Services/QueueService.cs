using Azure.Storage.Queues;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;


namespace TicketHubAPI.Services
{
    public class QueueService
    {
        private readonly QueueClient _queueClient;

        public QueueService(IConfiguration configuration)
        {
            string connectionString = configuration["AzureStorage:ConnectionString"];
            string queueName = configuration["AzureStorage:QueueName"];

            _queueClient = new QueueClient(connectionString, queueName);
            _queueClient.CreateIfNotExists();
        }

        public async Task SendMessageAsync(TicketPurchase ticket)
        {
            string message = JsonSerializer.Serialize(ticket);
            await _queueClient.SendMessageAsync(message);
        }
    }
}
