using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;

namespace ZZ_Fashion {
    public class Database {

        public static readonly Database INSTANCE = new Database(ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString());


        private string url;


        private Database(string url) {
            this.url = url;
        }


        public void Bind(GridView view, string query, Action<SqlException> handle) {
            Try (connection => {
                using (var table = new DataTable()) {
                    table.Load(new SqlCommand(query, connection).ExecuteReader());
                    view.DataSource = table;
                    view.DataBind();
                }

            }, handle);
        }

        public void Execute(string statement, Action<SqlCommand> execute, Action<SqlException> handle) {
            Try (connection => execute(new SqlCommand(statement, connection)), handle);
        }


        private void Try(Action<SqlConnection> execute, Action<SqlException> handle) {
            try {
                using (var connection = new SqlConnection()) {
                    connection.Open();
                    execute(connection);
                }

            } catch (SqlException e) {
                handle(e);
            }
        }

    }
}