using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dto
{
    public class UserDto
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public List<TaskDto> Tasks { get; set; }
    }
}