using System;
using System.Collections.Generic;

namespace CaKoi.Respository.Entities;

public partial class DonCt
{
    public int? Idkh { get; set; }

    public int? IdcaKoi { get; set; }

    public string? TenLoai { get; set; }

    public int? SoLuong { get; set; }

    public double? Gia { get; set; }

    public double? TongTien { get; set; }

    public int IdchiTiet { get; set; }
}
