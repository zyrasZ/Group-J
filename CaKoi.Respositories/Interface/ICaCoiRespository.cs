using CaKoi.Respositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaKoi.Respositories.Interface
{
    public interface ICaCoiRespository
    {
<<<<<<< HEAD
        CaCoi GetItemByCaKoiId(int id);
        Task<List<CaCoi>> GetCaCois();
        void DeleteCa(int id);
=======
        Task<List<CaCoi>> GetCaCois();
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
    }
}
