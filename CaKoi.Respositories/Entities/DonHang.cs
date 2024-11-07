using System;
using System.Collections.Generic;

namespace CaKoi.Respositories.Entities;

public partial class DonHang
{
    public int IddonHang { get; set; }

    public int? Idkh { get; set; }

    public DateOnly? NgayMua { get; set; }

    public DateOnly? NgayGiao { get; set; }

    public string? TrangThai { get; set; }
<<<<<<< HEAD

    public string? ChoDuyet { get; set; }
=======
>>>>>>> cf7a9847859f73a1fb7551d65a287d0e7c781ced
}
