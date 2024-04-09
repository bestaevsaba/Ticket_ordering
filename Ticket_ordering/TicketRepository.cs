using Ticket_ordering.Models;
using Microsoft.AspNetCore.DataProtection.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Ticket_ordering
{
    public class TicketRepository : ITicketRepository
    {
        private List<Ticket> tickets = new List<Ticket>()
        {
            new Ticket("Bob","A14",12000),
            new Ticket("Ben","A67",19000)
        };

        public List<Ticket> GetAll()
        {
            return tickets;
        }
        public void Update(Ticket ticket)
        {
            var existingProduct = tickets.FirstOrDefault(x => x.Id == ticket.Id);
            if (existingProduct == null) return;

            existingProduct.Name = ticket.Name;
            existingProduct.Seat = ticket.Seat;
            existingProduct.Cost = ticket.Cost;
        }
    }
}
