﻿using System;
using System.Collections.Generic;

namespace CaKoi.Respositories.Entities;

public partial class NhanVien
{
    public int Idnv { get; set; }

    public string? TenTaiKhoan { get; set; }

    public string? MatKhau { get; set; }

    public string? Hoten { get; set; }

    public DateOnly? Ngaysinh { get; set; }

    public string? Gioitinh { get; set; }

    public string? Sdt { get; set; }

    public string? Email { get; set; }
}
