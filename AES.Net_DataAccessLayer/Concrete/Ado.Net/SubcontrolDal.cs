using AES.Net_CoreLayer.DataAccessLayer.Ado.Net.Concrete;
using AES.Net_CoreLayer.DataAccessLayer.Ado.Net.Operations.GeneralOperations;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace AES.Net_DataAccessLayer.Concrete.Ado.Net
{
    public class SubcontrolDal : EntityRepository<Subcontrol>, ISubcontrolDal
    {
        public List<Subcontrol> SelectSubcontrol(string SUBID, DateTime DDATE)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand($"sp_Subcontrol_SelectWithDDATEAndSUBID", Tools.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SUBID", SUBID);
            cmd.Parameters.AddWithValue("@DDATE", DDATE);
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt.ToList<Subcontrol>();
        }

        public bool DeleteSubcontrol(int id)
        {
            SqlCommand cmd = new SqlCommand($"sp_Subcontrol_Delete", Tools.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", id);
            Tools.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            Tools.Connection.Close();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateSubcontrol(Subcontrol subcontrol, DateTime old_DDATE)
        {
            SqlCommand cmd = new SqlCommand($"sp_Subcontrol_Update", Tools.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            Type type = typeof(Subcontrol);
            PropertyInfo[] propertyInfos = type.GetProperties();
            subcontrol.VERIFIED_CH = "0";
            foreach (var pi in propertyInfos)
            {
                cmd.Parameters.AddWithValue($"@{pi.Name}", pi.GetValue(subcontrol));
            }
            cmd.Parameters.AddWithValue($"@OLD_DDATE", old_DDATE);
            if (Tools.Connection.State == ConnectionState.Closed)
            {
                Tools.Connection.Open();
            }
            int result = cmd.ExecuteNonQuery();
            if (Tools.Connection.State == ConnectionState.Open)
            {
                Tools.Connection.Close();
            }
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
