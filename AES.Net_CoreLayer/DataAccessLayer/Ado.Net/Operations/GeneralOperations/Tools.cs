using AES.Net_CoreLayer.DTO;
using AES.Net_CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;

namespace AES.Net_CoreLayer.DataAccessLayer.Ado.Net.Operations.GeneralOperations
{
    public static class Tools
    {
        private static SqlConnection connection;

        public static SqlConnection Connection
        {
            get
            {
                if (connection==null)
                {
                    connection = new SqlConnection("Server=.;Database=AESNETDatabase;Integrated Security=true;");
                }

                return connection;
            }
        }

        public static List<TT> ToList<TT>(this DataTable dt) where TT:class,new()
        {
            List<TT> list = new List<TT>();
            Type type = typeof(TT);
            PropertyInfo[] properties = type.GetProperties();

            foreach (DataRow row in dt.Rows)
            {
                TT entity = new TT();

                foreach (PropertyInfo prop in properties)
                {
                    if (row[prop.Name]!=null)
                    {
                        object value = row[prop.Name];
                        if (value is System.DBNull)
                        {
                            continue;
                        }
                        else
                        {
                            switch (prop.PropertyType.Name)
                            {
                                case "Int32":value=Convert.ToInt32(value);
                                    break;
                                case "String": value = Convert.ToString(value);
                                    break;
                                case "DateTime": value = Convert.ToDateTime(value);
                                    break;
                                case "Double": value = Convert.ToDouble(value);
                                    break;
                                default:
                                    break;
                            }
                            prop.SetValue(entity, value);
                        }
                        
                    }
                }

                list.Add(entity);
            }

            return list;
        }
    }
}
