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

<<<<<<< HEAD
        public void DeleteCa(int id)
        {
            var ca = _db.CaCois.FirstOrDefault(i => i.IdcaKoi == id);
            if (ca != null)
            {
                _db.CaCois.Remove(ca);
                _db.SaveChanges();
            }
        }

=======
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
        public async Task<List<CaCoi>> GetCaCois()
        {
            return await _db.CaCois.ToListAsync();
        }
<<<<<<< HEAD
        
        public CaCoi GetItemByCaKoiId(int id)
        {
            return _db.CaCois.Where(ca => ca.IdcaKoi == id).FirstOrDefault();
        }
=======
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
    }
}
