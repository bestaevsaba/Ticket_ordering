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
            new Ticket("Bob","31A",12000),
            new Ticket("Ben","1C",19000),
            new Ticket("Den","23A",12000),
            new Ticket("Alex","14D",19000),
            new Ticket("Trevor","12D",12000),
            new Ticket("Franklin","A67",19000),
            new Ticket("Bob","A14",12000),
            new Ticket("Ben","A67",19000),
        };

        public void Add(Ticket ticket)
        {
            tickets.Add(ticket);
        }

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
        public void Delete(int ticketId)
        {
            var ticketToRemove = tickets.FirstOrDefault(x => x.Id == ticketId);
            if (ticketToRemove != null)
            {
                tickets.Remove(ticketToRemove);
            }
        }
    }
}
