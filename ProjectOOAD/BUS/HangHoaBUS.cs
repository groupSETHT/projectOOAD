﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DTO;
using DAL;

namespace BUS
{
    public class HangHoaBUS
    {
        HangHoaDAL objHangHoa = new HangHoaDAL();
        public DataTable GetAllHangHoa()
        {
            return objHangHoa.GetAllHangHoa();
        }
    }
}
