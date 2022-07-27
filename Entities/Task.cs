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
        public Unit estimationUnit { get; set; }
        public int estimatedTime { get; set; }
        public Status Status { get; set; } = Status.TODO;
        public DateTime Date { get; set; } = DateTime.Now;
        public Nullable<DateTime> DueDate { get; set; } = null;
        public Importance Importance { get; set; } = Importance.LOW;
        public string UserId { get; set; }
        public User User { get; set; }
    }
}