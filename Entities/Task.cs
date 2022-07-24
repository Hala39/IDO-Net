using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public Estimate Estimate { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public DateTime DueDate { get; set; }
        public Status Status { get; set; } = Status.toDo;
        public Importance Importance { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
    }
}