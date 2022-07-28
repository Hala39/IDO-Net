using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dto
{
    public class NewTaskDto
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string estimationUnit { get; set; }
        public int estimatedTime { get; set; }
        public Nullable<DateTime> DueDate { get; set; }
        public Importance Importance { get; set; } = Importance.LOW;
        public Status Status { get; set; } = Status.TODO;
        public string UserId { get; set; }
    }
}