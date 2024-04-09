using Ticket_ordering.Models;

namespace Ticket_ordering
{
    public interface ITicketRepository
    {
        List<Ticket> GetAll();
        void Update(Ticket ticket);
        void Add(Ticket ticket);
        void Delete(int ticketId);
        Ticket TryGetById(int id);
    }
}
