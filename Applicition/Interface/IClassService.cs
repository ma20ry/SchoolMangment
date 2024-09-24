using Domains.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IClassService
    {
        Task<bool> Create(ClassCreateDTO classes);
        Task<bool> Update(ClassUpdateDTO classes);
        Task<ClassDeleteDTO> Delete(int id);
        Task<ClassUpdateDTO> GetByIdAsync(int id);

    }
}
