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
        Task<List<CaCoi>> GetCaCois();
    }
}
