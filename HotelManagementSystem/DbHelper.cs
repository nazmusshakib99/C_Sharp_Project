using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace OOP2FinalClassProject
{

    public class Result



    {

        public DataTable Data;
        public bool HasError;
        public string Message;
    }

    internal class DbHelper
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-J6UI3P3\\SQLEXPRESS;Initial Catalog=FinalProjectDb;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Application " +
                                                       "Name=\"Microsoft SQL Server Data Tools, SQL Server Object Explorer\";Command Timeout=0");


        public static Result GetQueryData(string query)
        {
            var result = new Result();

            try
            {
                con.Open();

                SqlDataAdapter adp = new SqlDataAdapter(query, con);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                DataTable dt = ds.Tables[0];

                con.Close();

                result.Data = dt;
            }
            catch (Exception e)
            {
                result.HasError = true;
                result.Message = e.Message;
            }
            return result;
        }

        public static Result ExecuteNonResultQuery(string query)
        {
            var result = new Result();

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception e)
            {
                result.HasError = true;
                result.Message = e.Message;
            }

            return result;
        }
    }
}