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
        CaCoi GetItemByCaKoiId(int id);
        Task<List<CaCoi>> GetCaCois();
        void DeleteCa(int id);
    }
}
