using CaKoi.Respositories.Entities;
using CaKoi.Respositories.Interface;
using CaKoi.Services.Interface;
<<<<<<< HEAD
using Microsoft.AspNetCore.Http;
=======
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaKoi.Services
{
    public class CaCoiService : ICaCoiService
    {
        public readonly ICaCoiRespository _respository;
        public CaCoiService(ICaCoiRespository respository)
        {
            _respository = respository;
        }

<<<<<<< HEAD
        public CaCoi GetCaKoiByID(int id)
        {
            return _respository.GetItemByCaKoiId(id);
        }
       
=======
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
        public Task<List<CaCoi>> GetCaCois()
        {
            return _respository.GetCaCois();
        }
    }
}
