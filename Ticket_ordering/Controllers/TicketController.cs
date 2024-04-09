﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticket_ordering.Models;

namespace Ticket_ordering.Controllers
{
    public class TicketController : Controller
    {
        private readonly ITicketRepository ticketRepository;

        public TicketController(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public ActionResult Sale()
        {
            var ticket = ticketRepository.GetAll();
            return View(ticket);
        }
        public IActionResult AddClient()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddClient(Ticket ticket)
        {
            if (!ModelState.IsValid) return View(ticket);
            ticketRepository.Add(ticket);
            return RedirectToAction("Sale");
        }


    }
}
