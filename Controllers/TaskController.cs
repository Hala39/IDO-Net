using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _taskRepo;

        public TaskController(ITaskRepository taskRepo)
        {
            _taskRepo = taskRepo;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Result<TaskDto>>> GetTaskById(int id)
        {
            return Ok(await _taskRepo.GetTaskById(id));
        }

        [HttpGet]
        public async Task<ActionResult<Result<List<TaskDto>>>> GetTasksForUser()
        {
            return Ok(await _taskRepo.GetTasksForUser());
        }

        [HttpPost]
        public async Task<ActionResult<Result<TaskDto>>> AddTask(NewTaskDto newTask)
        {
            return Ok(await _taskRepo.AddTask(newTask));
        }

        [HttpPut]
        public async Task<ActionResult<Result<TaskDto>>> UpdateTask(UpdateTaskDto updatedTask)
        {
            return Ok(await _taskRepo.UpdateTask(updatedTask));
        }

        [HttpPut("status")]
        public async Task<ActionResult<Result<TaskDto>>> UpdateTaskStatus(UpdateTaskStatusDto updatedTask)
        {
            return Ok(await _taskRepo.UpdateStatus(updatedTask));
        }
    }
}