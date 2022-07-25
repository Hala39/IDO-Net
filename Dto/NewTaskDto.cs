using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dto
{
    public class NewTaskDto
    {
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public Unit estimationUnit { get; set; }
        public int estimatedTime { get; set; }
        public Nullable<DateTime> DueDate { get; set; }
        public Nullable<Importance> Importance { get; set; } = null;
        public string UserId { get; set; }
    }
}