using AES.Net_CoreLayer.DataAccessLayer.Ado.Net.Operations.GeneralOperations;
using AES.Net_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace AES.Net_CoreLayer.DataAccessLayer.Ado.Net.Concrete
{
    public class EntityRepository<TT> : IEntityRepository<TT>
        where TT : class, IEntity, new()
    {
        private Type GetirType
        {
            get
            {
                return typeof(TT);
            }
        }
        public bool Add(TT entity)
        {
            SqlCommand cmd = new SqlCommand($"sp_{GetirType.Name}_Insert", Tools.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            PropertyInfo[] propertyInfos = GetirType.GetProperties();

            foreach (var pi in propertyInfos)
            {
                cmd.Parameters.AddWithValue($"@{pi.Name}", pi.GetValue(entity));
            }
            if (Tools.Connection.State==ConnectionState.Closed)
            {
                Tools.Connection.Open();
            }
            int result = cmd.ExecuteNonQuery();
            if (Tools.Connection.State == ConnectionState.Open)
            {
                Tools.Connection.Close();
            }
            if (result>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(string id)
        {
            SqlCommand cmd = new SqlCommand($"sp_{GetirType.Name}_Delete", Tools.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            PropertyInfo[] propertyInfos = GetirType.GetProperties();

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

        public TT Get(string procName, string id)
        {
            throw new NotImplementedException();
        }

        public List<TT> GetAll()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand($"sp_{GetirType.Name}_SelectAll",Tools.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt.ToList<TT>();

        }

        public List<TT> GetAllWithID(object id)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand($"sp_{GetirType.Name}_Select",Tools.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID",id);
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt.ToList<TT>();

        }

        public bool Update(TT entity)
        {
            SqlCommand cmd = new SqlCommand($"sp_{GetirType.Name}_Update", Tools.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            PropertyInfo[] propertyInfos = GetirType.GetProperties();

            foreach (var pi in propertyInfos)
            {
                cmd.Parameters.AddWithValue($"@{pi.Name}", pi.GetValue(entity));
            }
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
