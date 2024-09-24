using Domains.DTO;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IStudentService
    {
        Task<bool> Create(StudentCreateDTO students);
        Task<bool> Update(StudentUpdateDTO Studen);
        Task<StudentDeleteDTO> Delete(int id);
        Task<StudentDTO> GetByIdAsync(int id);
    }
}
