using System.ComponentModel.DataAnnotations;

namespace Ticket_ordering.Models
{
    public class Ticket
    {
        private static int IdCreate = 0;

        [Required(ErrorMessage = "ФИО пассажира обязательно для заполнения")]
        [RegularExpression(@"^[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+$", ErrorMessage = "ФИО пассажира должно содержать три слова, начинающихся с заглавной буквы")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Номер места обязателен для заполнения")]
        [RegularExpression(@"^[1-9][0-9]?[ABCDEF]$", ErrorMessage = "Номер места должен быть числом от 1 до 32, за которым следует одна из букв ABCDEF")]
        public string Seat { get; set; }

        [Display(Name = "Дата покупки")]
        public DateTime PurchaseDate { get; set; }

        [Required(ErrorMessage = "Стоимость билета обязательна для заполнения")]
        [Range(1000, double.MaxValue, ErrorMessage = "Стоимость билета должна быть не менее 1000")]
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
