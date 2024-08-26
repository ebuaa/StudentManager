using Microsoft.AspNetCore.Mvc;
using StudentManager.Models;
using StudentManager.Data;
using Microsoft.EntityFrameworkCore;


namespace StudentManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

    }
}
