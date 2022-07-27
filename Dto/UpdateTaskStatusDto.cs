using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dto
{
    public class UpdateTaskStatusDto
    {
        public int TaskId { get; set; }
        public int TargetStatusIndex { get; set; }
    }
}