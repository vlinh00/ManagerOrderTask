﻿using AT.Server.Data;
using AT.Share.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Security.Claims;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AT.Server.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class ManagerTaskController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ManagerTaskController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<ManagerTaskController>
        [HttpGet("all-task")]
        public async Task<ActionResult<IEnumerable<TaskModel>>> GetAllTask()
        {
            return await _context.Tasks.ToListAsync();
        }

        // GET api/<ManagerTaskController>
        [HttpGet("all-task-by-UserId")]

        public async Task<ActionResult<IEnumerable<TaskModel>>> GetAllTaskByUserId()
        {
            string userId = GetUserId();
            return await _context.Tasks.Where(task => task.StaffId == userId).ToListAsync();
        }

        // GET api/<ManagerTaskController>/5
        [HttpGet("{id}")]

        public async Task<ActionResult<TaskModel>> GetTaskById(int id)
        {
            var task = await _context.Tasks.FirstOrDefaultAsync(t => t.Id == id);

            if (task == null)
            {
                return NotFound(); // Trả về NotFound nếu không tìm thấy
            }

            return Ok(task); // Trả về task tìm thấy
        }

        // POST api/<ManagerTaskController>
        [HttpPost]
        public async Task<ActionResult<bool>> PostTaskModel(TaskModel taskModel)
        {
            _context.Tasks.Add(taskModel);
            await _context.SaveChangesAsync();

            return Ok();
        }

        // PUT api/<ManagerTaskController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskModel(int id, TaskModel taskModel)
        {
            if (id != taskModel.Id)
            {
                return BadRequest();
            }

            _context.Entry(taskModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TaskModelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE api/<ManagerTaskController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskModel(int id)
        {
            var taskModel = await _context.Tasks.FindAsync(id);
            if (taskModel == null)
            {
                return NotFound();
            }

            _context.Tasks.Remove(taskModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        private bool TaskModelExists(int id)
        {
            return _context.Tasks.Any(e => e.Id == id);
        }
        private string GetUserId()
        {
           var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            return userIdClaim != null ? userIdClaim.Value : string.Empty;
        }
        
    }
}
