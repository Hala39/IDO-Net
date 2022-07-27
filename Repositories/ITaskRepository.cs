using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public interface ITaskRepository
    {
        Task<Result<TaskDto>> GetTaskById(int id);
        Task<Result<List<TaskDto>>> GetTasksForUser();
        Task<Result<TaskDto>> AddTask(NewTaskDto newTask);
        Task<Result<TaskDto>> UpdateTask(UpdateTaskDto updatedTask);
        Task<Result<TaskDto>> UpdateStatus(UpdateTaskStatusDto updateTaskStatusDto);
    }
}