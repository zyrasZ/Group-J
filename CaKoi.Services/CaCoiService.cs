﻿using CaKoi.Respositories.Entities;
using CaKoi.Respositories.Interface;
using CaKoi.Services.Interface;
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

        public Task<List<CaCoi>> GetCaCois()
        {
            return _respository.GetCaCois();
        }
    }
}
