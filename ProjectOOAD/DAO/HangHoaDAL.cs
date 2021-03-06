﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using DTO;

namespace DAL
{
    public class HangHoaDAL : DBConnection
    {
        public HangHoaDAL() : base() { }
        public DataTable GetByNhaCungCap(string maNCC)
        {
            try
            {
                if(conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("HangHoa_GetByNhaCungCap", conn);
                cmd.Parameters.Add("@maNCC", SqlDbType.VarChar).Value = maNCC;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Close();
            }
            catch
            {
                conn.Close();
            }
            return null;
        }
    }
}
