using Acme.PhoneBookDemo.Dto;

namespace Acme.PhoneBookDemo.WebHooks.Dto
{
    public class GetAllSendAttemptsInput : PagedInputDto
    {
        public string SubscriptionId { get; set; }
    }
}
