using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WinFormsApp3 {
    internal class DAO {

        //连接x`
        public static SqlConnection Connection() {
            SqlConnection connection = new SqlConnection("server=.;database=bo;user id=sa;password=qiongbb");
            connection.Open();
            return connection;
        }

        public static SqlCommand Command(string sql) {
            SqlCommand command = new SqlCommand(sql, Connection());
            return command;
        }

        //增删改操作
        public static int Execute(string sql) {
            return Command(sql).ExecuteNonQuery();
        }

        //查询操作
        public static SqlDataReader Query(string sql) {
            return Command(sql).ExecuteReader();
        }
    }
}
