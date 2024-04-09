namespace Ticket_ordering.Models
{
    public class Ticket
    {
        private static int IdCreate = -1;
        public string Name { get; set; }

        public string Seat { get; set; }
        public decimal Cost { get; set; }

        public int Id { get; }

        public Ticket(string name, string seat, decimal cost)
        {
            Id = IdCreate++;
            Name = name;
            Seat = seat;
            Cost = cost;
        }
        public Ticket() { }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Seat}\n{Cost}";
        }

    }
}
