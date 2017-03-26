using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
/// <summary>
/// Johnson 的 ADO.NET 簡易操作類別庫
/// </summary>
namespace ezClass
{
    /// <summary>
    /// Johnson 的 ADO.NET 簡易操作類別
    /// </summary>
    public class ezadonet
    {
        private SqlConnection _conn;
        private SqlCommand _cmd;
        /// <summary>
        /// 建構子
        /// </summary>
        public ezadonet()
        {
            _conn = new SqlConnection();
            _cmd = new SqlCommand();
            _cmd.Connection = _conn;
        }
        /// <summary>
        /// 連線物件
        /// </summary>
        public SqlConnection conn
        {
            get { return _conn; }
            set { _conn = value; }
        }
        /// <summary>
        /// 命令物件
        /// </summary>
        public SqlCommand cmd
        {
            get { return _cmd; }
            set { _cmd = value; }
        }

        public string CommandText
        {
            get { return _cmd.CommandText; }
            set { _cmd.CommandText = value; }
        }

        public bool HasRow
        {
            get
            {
                bool bln_hasrow = false;
                SqlDataReader dr = _cmd.ExecuteReader();
                bln_hasrow = dr.HasRows;
                dr.Close();
                return bln_hasrow;
            }
        }

        public void Open()
        {
            _conn.ConnectionString = WebConfigurationManager.ConnectionStrings["dbconn"].ConnectionString;
            _conn.Open();
        }

        public void Close()
        {
            _conn.Close();
        }

        public void ParametersAdd(string sParmName , object oValue , bool bClear)
        {
            if (bClear) _cmd.Parameters.Clear();
            _cmd.Parameters.AddWithValue(sParmName, oValue);
        }

        public void ExecuteNonQuery(bool bClose)
        {
            _cmd.ExecuteNonQuery();
            if (bClose) Close();
        }

        public string GetStringValue(string sColName)
        {
            string str_value = string.Empty;

            SqlDataReader dr = _cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                str_value = (dr[sColName] == null) ? string.Empty : dr[sColName].ToString();
            }
            dr.Close();

            return str_value;
        }

        public int GetIntValue(string sColName)
        {
            int int_value = 0;
            string str_value = GetStringValue(sColName);
            if (!string.IsNullOrEmpty(str_value)) int_value = int.Parse(str_value);
            return int_value;
        }
    }
}