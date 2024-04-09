using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ticket_ordering.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketRepository ticketRepository;

        public TicketController(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public ActionResult Index()
        {
            var ticket = ticketRepository.GetAll();
            return View(ticket);

        }
        public ActionResult Sale()
        {
            var ticket = ticketRepository.GetAll();
            return View(ticket);

        }

    }
}
