using Application.Helper;
using Application.Interface;
using Application.Services;
using Domains.DTO;
using Domains.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IClassService _ClassService;
      

        public ClassController(IClassService classService)
        {
            _ClassService = classService;
          
        }
        [HttpPost]

        public async Task<ActionResult<Class>> Create(ClassCreateDTO classes)
        {
            var data = await _ClassService.Create(classes);

            if (data == null)
            {
                return NotFound();
            }
            return Ok(data);

        }
        [HttpPut]
        public async Task<ActionResult<bool>> Update(ClassUpdateDTO classes)
        {
            if (classes == null)
            {
                return BadRequest("Invalid class ID.");
            }
            return await _ClassService.Update(classes);


        }
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var std = await _ClassService.Delete(id);

            if (id == null)
            {
                return BadRequest("Invalid class ID.");
            }

            if (std == null)
            {
                return NotFound("class not found.");
            }
            return Ok(std);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassUpdateDTO>> GetByIdAsync(int id)
        {
            var data = await _ClassService.GetByIdAsync(id);

            if (data == null)
            {
                return NotFound("No Studen found.");
            }

            return Ok(data);
        }
    }
}
