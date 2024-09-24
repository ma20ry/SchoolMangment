using Application.Interface;
using AutoMapper;
using Domains.DTO;
using Domains.Models;
using InfraStructure.DBContext;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Application.Services
{
    public class ClassService : IClassService
    {

        private readonly ApplicationDBContextcs _context;
        private readonly IMapper _mapper;

        public ClassService(ApplicationDBContextcs context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<bool> Create(ClassCreateDTO classes)
        {
            var data = _mapper.Map<Class>(classes);
           
            if (data.NumberofStudents > 30)
            {
                return false;

            }
            _context.classes.Add(data);
            await _context.SaveChangesAsync();
            return true;

        }
        public async Task<bool> Update(ClassUpdateDTO classes)
        {
            var data = await _context.classes.FindAsync(classes.Id);
            var result = _mapper.Map(classes, data);
            _context.classes.Update(result);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<ClassDeleteDTO> Delete(int id)
        {
            var cl = await _context.classes.FirstOrDefaultAsync(x => x.Id == id);
            if (cl != null)
            {
                cl.IsDeleted = true;
                _context.classes.Update(cl);
                _context.SaveChanges();

                var deleteDto = _mapper.Map<ClassDeleteDTO>(cl);
                deleteDto.Message = "Class successfully deleted.";
                return deleteDto;
            }
            else
            {
                return null;
            }


        }
        public async Task<ClassUpdateDTO> GetByIdAsync(int id)
        {

            var students = await _context.classes.Where(x => x.IsDeleted == false && x.Id == id).FirstOrDefaultAsync();
            if (students == null)
            {
                return null; // Or throw an exception if preferred
            }
            return _mapper.Map<ClassUpdateDTO>(students);

        }

    }
}
