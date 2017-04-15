using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace SmartHeatStation.SQLserver
{
    public class ComWithSql
    {

        SqlCommand command;
        SqlConnection con;

        public ComWithSql()
        {
            con = new SqlConnection();
            con.ConnectionString = "server=.;database=jzrd_hrzh;uid=sa;pwd=123";
            con.Open();          
            MessageBox.Show("连接成功！");

            //con.Close();
        }

        ~ComWithSql()
        {
            con.Close();
        }

        public string FindData()
        {
            command = new SqlCommand();
            command.Connection = con;
            //command.CommandType = CommandType.Text;
            command.CommandText = "SELECT [gather_seconds] FROM [dbo].[gather_parms]";
            var abc = command.ExecuteNonQuery();
            if (abc != -1)
                return "";
            SqlDataReader dataReader = command.ExecuteReader();
            string str = "";
            while (dataReader.Read())
            {
                str = dataReader["gather_seconds"] + " ";
            }
            dataReader.Close();
            return str;
        }

    }
}
