using AES.Net_CoreLayer.DataAccessLayer.Ado.Net.Concrete;
using AES.Net_CoreLayer.DataAccessLayer.Ado.Net.Operations.GeneralOperations;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_DataTransactObject.Concrete;
using AES.Net_Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AES.Net_DataAccessLayer.Concrete.Ado.Net
{
    public class SubscriberDal : EntityRepository<Subscriber>, ISubscriberDal
    {
        public List<SubscriberSearchDTO> GetSubscriberSearchDTOs()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("sp_Subscriber_List", Tools.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt.ToList<SubscriberSearchDTO>();
        }

        public List<SubscriberSearchDTO> GetSubscriberSearchDTOEntitiy(string id)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("sp_Subscriber_List_WithSUBID", Tools.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            cmd.Parameters.AddWithValue("@ID", id);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt.ToList<SubscriberSearchDTO>();
        }
    }
}
