using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RallyBuilder.Models;

namespace RallyBuilder.Services
{
    public interface IRallyService
    {
        Task<List<Rally>> GetAllRallies();
    }
}
