using Microsoft.AspNetCore.Mvc;
using TicketHubAPI.Services;  // Assuming a service is created for Azure Queue
using System.Threading.Tasks;

namespace TicketHubAPI.Controllers
{
    [ApiController]
    [Route("api/tickets")]
    public class TicketPurchaseController : ControllerBase
    {
        private readonly QueueService _queueService;

        public TicketPurchaseController(QueueService queueService)
        {
            _queueService = queueService;
        }

        [HttpPost("purchase")]
        public async Task<IActionResult> PurchaseTicket([FromBody] TicketPurchase ticket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Send ticket purchase to Azure Queue
            await _queueService.SendMessageAsync(ticket);
            return Ok(new { message = "Ticket purchase request received." });
        }
    }
}
