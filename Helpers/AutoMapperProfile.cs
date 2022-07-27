using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<AppTask, TaskDto>().ReverseMap();
            CreateMap<NewTaskDto, AppTask>().ReverseMap();
            CreateMap<NewTaskDto, TaskDto>().ReverseMap();
            CreateMap<AppTask, UpdateTaskStatusDto>().ReverseMap();
            CreateMap<TaskDto, AppTask>();
            CreateMap<AppTask, TaskDto>();
        }
    }
}
