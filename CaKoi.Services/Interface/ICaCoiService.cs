using CaKoi.Respositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaKoi.Services.Interface
{
    public interface ICaCoiService
    {
        Task<List<CaCoi>> GetCaCois();
<<<<<<< HEAD
        CaCoi GetCaKoiByID(int id);
=======
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
    }
}
