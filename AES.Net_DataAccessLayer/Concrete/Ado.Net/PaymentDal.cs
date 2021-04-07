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
    public class PaymentDal : EntityRepository<Payment>, IPaymentDal
    {
        public List<Payment> SelectPayment(string SUBID,DateTime DDATE, int CHARGE, string FORM_OF_PAYMENT)
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand($"sp_Payment_SelectPayment", Tools.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SUBID", SUBID);
            cmd.Parameters.AddWithValue("@DDATE", DDATE);
            cmd.Parameters.AddWithValue("@CHARGE", CHARGE);
            cmd.Parameters.AddWithValue("@FORM_OF_PAYMENT", FORM_OF_PAYMENT);
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt.ToList<Payment>();
        }

        public bool UpdatePayment(Payment payment, DateTime old_DDATE)
        {
            SqlCommand cmd = new SqlCommand($"sp_Payment_Update", Tools.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            Type type = typeof(Payment);
            PropertyInfo[] propertyInfos = type.GetProperties();

            foreach (var pi in propertyInfos)
            {
                cmd.Parameters.AddWithValue($"@{pi.Name}", pi.GetValue(payment));
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

        public bool DeletePayment(string SUBID,DateTime DDATE,int CHARGE)
        {
            SqlCommand cmd = new SqlCommand($"sp_Payment_Delete", Tools.Connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue($"@SUBID", SUBID);
            cmd.Parameters.AddWithValue($"@DDATE", DDATE);
            cmd.Parameters.AddWithValue($"@CHARGE", CHARGE);
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
