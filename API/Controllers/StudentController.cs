using Application.Helper;
using Application.Interface;
using Application.Services;
using Domains.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _StudentService;
        private readonly ISaveFile saveFile;

        public StudentController(IStudentService studentService, ISaveFile saveFile)
        {
            _StudentService = studentService;
            this.saveFile = saveFile;
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromForm] StudentCreateDTO std, IFormFile file)
        {
            if (file != null)
            {
                std.img = $"https://{HttpContext.Request.Host.Value}" + await saveFile.SaveFileAsync("Img", file);

            }
            var data = await _StudentService.Create(std);

            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }
        [HttpPut]
        public async Task<ActionResult<bool>> Update(StudentUpdateDTO Studen)
        {
            if (Studen == null)
            {
                return BadRequest("Invalid Studen ID.");
            }
            return await _StudentService.Update(Studen);


        }
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var std = await _StudentService.Delete(id);

            if (id == null)
            {
                return BadRequest("Invalid Studen ID.");
            }

            if (std == null)
            {
                return NotFound("Studen not found.");
            }
            return Ok(std);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentDTO>> GetByIdAsync(int id)
        {
            var data = await _StudentService.GetByIdAsync(id);

            if (data == null )
            {
                return NotFound("No Studen found.");
            }

            return Ok(data);
        }

    }
}
