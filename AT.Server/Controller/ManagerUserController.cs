using AT.Server.Data;
using AT.Share.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AT.Server.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerUserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ManagerUserController(ApplicationDbContext context)
        {
           _context = context;
        }
        // GET: api/<ManagerUserController>
        [HttpGet("all-user")]
        public async Task<ActionResult<IEnumerable<Staff>>> GetAllUser()
        {
            return await _context.Staffs.ToListAsync();
        }

        [HttpGet("all-groupuser")]
        public async Task<ActionResult<IEnumerable<GroupUser>>> GetAllGroupUser()
        {
            return await _context.GroupUsers.ToListAsync();
        }

        [HttpGet("all-user-info")]
        public async Task<ActionResult<IEnumerable<StaffInfo>>> GetAllUserInfo()
        {
            var result = await (from staff in _context.Staffs
                                               join department in _context.Departments
                                               on staff.DepartmentId equals department.Id
                                               join groupUser in _context.GroupUsers
                                               on staff.GroupUserId equals groupUser.Id
                                               select new StaffInfo
                                               {
                                                   staffs = staff,
                                                   DepartmentName = department.Name,
                                                   GroupUserName = groupUser.GroupName
                                               }).ToListAsync();
  
            return Ok(result);
        }

        // GET api/<ManagerUserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ManagerUserController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ManagerUserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ManagerUserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
