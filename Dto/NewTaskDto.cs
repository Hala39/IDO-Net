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
        public Estimate Estimate { get; set; }
        public DateTime DueDate { get; set; }
        public Importance Importance { get; set; }
        public string UserId { get; set; }
    }
}