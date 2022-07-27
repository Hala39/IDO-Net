using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public TaskRepository(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }
        string GetUserId() => _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
        public async Task<Result<TaskDto>> AddTask(NewTaskDto newTask)
        {
            var result = new Result<NewTaskDto>();

            newTask.UserId = GetUserId();
            var mapped = _mapper.Map<AppTask>(newTask);

            await _context.Tasks.AddAsync(mapped);
            var success = await _context.SaveChangesAsync() > 0;

            if (success) return Result<TaskDto>.Success(_mapper.Map<TaskDto>(mapped));
            else return Result<TaskDto>.Failure("Operation failed!");
        }

        public async Task<Result<TaskDto>> GetTaskById(int id)
        {
            var result = new Result<TaskDto>();
            var task = await _context.Tasks.FindAsync(id);
            if (task != null) return Result<TaskDto>.Success(_mapper.Map<TaskDto>(task));
            else return Result<TaskDto>.Failure("Task not found!");
        }

        public async Task<Result<List<TaskDto>>> GetTasksForUser()
        {
            var result = new Result<TaskDto>();
            var tasks = await _context.Tasks
                .Where(t => t.UserId == GetUserId())
                .OrderByDescending(t => t.Date)
                .ToListAsync();
                
            if (tasks.Count > 0) return Result<List<TaskDto>>.Success(tasks.Select(t => _mapper.Map<TaskDto>(t)).ToList());
            else return Result<List<TaskDto>>.Failure("No tasks found!");
        }

        public async Task<Result<TaskDto>> UpdateTask(UpdateTaskDto updatedTask)
        {
            var result = new Result<TaskDto>();
            var targetTask = await GetTaskById(updatedTask.Id);
            targetTask.Value.Title = updatedTask.Title;
            var success = await _context.SaveChangesAsync() > 0;
            if (success) return Result<TaskDto>.Success(_mapper.Map<TaskDto>(updatedTask));
            else return Result<TaskDto>.Failure("Operation failed");
        }

        public async Task<Result<TaskDto>> UpdateStatus(UpdateTaskStatusDto updateTaskStatusDto)
        {
            
                var targetTask = await _context.Tasks.FirstOrDefaultAsync(t => t.Id == updateTaskStatusDto.TaskId);

                targetTask.Status = ((Status) updateTaskStatusDto.TargetStatusIndex);

                _context.Tasks.Update(targetTask);

            var success = await _context.SaveChangesAsync() > 0;
            if (success) return Result<TaskDto>.Success(_mapper.Map<TaskDto>(targetTask));
            else return Result<TaskDto>.Failure("Operation failed");

        }
    }
}