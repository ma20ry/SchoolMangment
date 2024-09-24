using Application.Helper;
using Application.Interface;
using AutoMapper;
using Domains.DTO;
using Domains.Models;
using InfraStructure.DBContext;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDBContextcs _context;
        private readonly IMapper _mapper;

        public StudentService(ApplicationDBContextcs context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Create(StudentCreateDTO students )
        {
            var std =  _mapper.Map<Student>(students);
            //List<Teacher> teachers = new List<Teacher>();
            //std.teachers= teachers;
            _context.students.Add(std);
            await _context.SaveChangesAsync();
            return true;

        }
        public async Task<bool> Update(StudentUpdateDTO Student)
        {
            var data = await _context.students.FindAsync(Student.Id);
            var result = _mapper.Map(Student, data);
            _context.students.Update(result);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<StudentDeleteDTO> Delete(int id)
        {
            var Studen = await _context.students.FirstOrDefaultAsync(x => x.Id == id);
            if (Studen != null)
            {
                Studen.IsDeleted = true;
                _context.students.Update(Studen);
                _context.SaveChanges();

                var deleteDto = _mapper.Map<StudentDeleteDTO>(Studen);
                deleteDto.Message = "Student successfully deleted.";
                return deleteDto;
            }
            else
            {
                return null;
            }


        }
        public async Task<StudentDTO> GetByIdAsync(int id)
        {

            var students = await _context.students.Where(x => x.IsDeleted == false && x.Id == id).FirstOrDefaultAsync();
            if (students == null)
            {
                return null; // Or throw an exception if preferred
            }
            return _mapper.Map<StudentDTO>(students);

         }


    }
}
