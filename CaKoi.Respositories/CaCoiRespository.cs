using CaKoi.Respositories.Entities;
using CaKoi.Respositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaKoi.Respositories
{
    public class CaCoiRespository : ICaCoiRespository
    {
        public readonly CaKoiContext _db;
        public CaCoiRespository(CaKoiContext db)
        {
            _db = db;
        }

        public async Task<List<CaCoi>> GetCaCois()
        {
            return await _db.CaCois.ToListAsync();
        }
    }
}
