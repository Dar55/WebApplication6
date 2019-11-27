using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace WebApplication6
{
    public class TakeData
    {
        public string takeHtml(string sCommand)
        {
            string connectionString = @"Data Source=wpl23.hosting.reg.ru;Initial Catalog=u0825580_12;User Id = u0825580_hos; Password = Xcna433~";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string sqlExpression = "SELECT html_code FROM table_content WHERE name=" + sCommand;
            SqlCommand command = new SqlCommand(sqlExpression, connection);

            SqlDataReader reader = command.ExecuteReader();
            string html_code = "";
            while (reader.Read())
            {
                html_code = reader["html_code"].ToString();

            }

            return html_code;
        }
    }
}
