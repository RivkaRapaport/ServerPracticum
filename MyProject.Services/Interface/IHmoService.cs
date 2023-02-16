using MyProject.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Interface
{
    public interface IHmoService
    {

        Task<List<HmoDTO>> GetAllAsync();

        Task<HmoDTO> GetByIdAsync(int id);

        Task<HmoDTO> AddAsync( string name, string description);

        Task<HmoDTO> UpdateAsync(HmoDTO hmo);

        Task DeleteAsync(int id);
    }
}
