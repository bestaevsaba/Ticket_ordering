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
            new Ticket("Иванов Петр Сергеевич","1A",12000),
            new Ticket("Петров Алексей Иванович","2B",19000),
            new Ticket("Сидоров Владимир Васильевич","3C",12000),
            new Ticket("Кузнецов Денис Александрович","4D",19000),
            new Ticket("Морозов Андрей Викторович","5E",12000),
            new Ticket("Новиков Константин Дмитриевич","6F",19000),
            new Ticket("Смирнов Михаил Александрович","7A",12000),
            new Ticket("Козлов Сергей Дмитриевич","8B",19000),
            new Ticket("Лебедев Александр Петрович","9C",12000),
            new Ticket("Попов Дмитрий Игоревич","10D",19000)
        };

        public void Add(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public List<Ticket> GetAll()
        {
            return tickets;
        }
        public Ticket TryGetById(int id)
        {
            return tickets.FirstOrDefault(ticket => ticket.Id == id);
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
